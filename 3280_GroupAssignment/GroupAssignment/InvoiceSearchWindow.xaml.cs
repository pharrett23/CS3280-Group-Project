using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GroupAssignment {
    /// <summary>
    /// Interaction logic for InvoiceSearchWindow.xaml
    /// </summary>
    public partial class InvoiceSearchWindow : Window {
        private Invoice selectedInvoice; 

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchWindow"/> class.
        /// </summary>
        public InvoiceSearchWindow() {
            try {
                InitializeComponent();
            } catch (Exception ex) {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the MainMenuBTN control.
        /// Returns to main menu
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void MainMenuBTN_Click(object sender, RoutedEventArgs e) {
            try {

            } catch (Exception ex) {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the ResetSearchInvoiceBTN control.
        /// Reset the search parameters.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ResetSearchInvoiceBTN_Click(object sender, RoutedEventArgs e) {
            try {

            } catch (Exception ex) {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the SearchInvoiceSubmitBTN control.
        /// Submit search parameters.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void SearchInvoiceSubmitBTN_Click(object sender, RoutedEventArgs e) {
            try {

            } catch (Exception ex) {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the SelectBTN control.
        /// Returns to main menu with selected invoice displayed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void SelectBTN_Click(object sender, RoutedEventArgs e) {
            try {

            } catch (Exception ex) {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// handles any errors that come up
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage) {
            try {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            } catch (Exception ex) {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                                            "HandleError Exception: " + ex.Message);
            }
        }
    }


}
