using AlterianEMAPIClient;
using AlterianEMAPIClient.DMListManager;
using AlterianEMAPI_WebForm.Authenticate;
using AlterianEMAPI_WebForm.Properties;

namespace AlterianEMAPI_WebForm.BizLogic
{
    internal class EMList
    {
        /// <summary>
        /// Download the records of a Email Manager list
        /// </summary>
        public void Download()
        {
            var token = Auth.GetToken();

            using (var em = new EMWebServicesClient(token, Settings.Default.EndPoint))
            {
                // Set Variable
                int listID = 1192; // List id can be loaded from app.config, if already know it.
                int fieldPrimaryKey;

                // Get list fields (columns)
                DMListField[] fields = em.ListManager.GetListFields(token, listID, out fieldPrimaryKey);

                // Get list records
                DMCursor dmCursor = new DMCursor();
                DMRecipientRecord[] dmRecords = em.ListManager.GetListRecords(token, listID, 999999, ref dmCursor, DMPreviewDirection.DMPD_FIRST);

                // Write the CSV file with the retrieve data
                WriteToCSVFile(fields, dmRecords);
            }
        }

        private void WriteToCSVFile(DMListField[] fields, DMRecipientRecord[] dmRecords)
        {
            // do something
        }
    }
}