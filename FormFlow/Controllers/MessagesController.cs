using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using HelloBot.Forms;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Connector;

namespace HelloBot
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                IDialog<MedicalQuestionForm> dialog = CreateDialogFromForm();
                await Conversation.SendAsync(activity, () => dialog);
            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        private IDialog<MedicalQuestionForm> CreateDialogFromForm()
        {
            return Chain.From(
                () => FormDialog.FromForm(
                    () => new MedicalQuestionFormBuilder().BuildForm()));
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                throw new NotImplementedException();
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                throw new NotImplementedException();
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                throw new NotImplementedException();
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                throw new NotImplementedException();
            }
            else if (message.Type == ActivityTypes.Ping)
            {
                throw new NotImplementedException();
            }
            return null;
        }
    }
}