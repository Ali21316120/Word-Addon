using Microsoft.Office.Core;
using Newtonsoft.Json;

namespace WordAddIn1
{
    public partial class ThisAddIn
    {
        protected override IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            var blabla = JsonConvert.SerializeObject("just a teste to prove that external dlls are working good");

            return new MyRibbon();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with
        /// the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion VSTO generated code
    }
}