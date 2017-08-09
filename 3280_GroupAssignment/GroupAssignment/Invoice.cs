using System.Collections.Generic;

namespace GroupAssignment {
    /// <summary>
    /// Invoice class. Holds all data that an invoices will contain.
    /// </summary>
    public class Invoice {
        /// <summary>
        /// The invoice number
        /// </summary>
        private string invoiceNum;
        /// <summary>
        /// The total charge
        /// </summary>
        private string totalCharge;
        /// <summary>
        /// The invoice date
        /// </summary>
        private string invoiceDate;
        /// <summary>
        /// The item codes.
        /// </summary>
        private List<char> items;
        /// <summary>
        /// Gets or sets the invoice number.
        /// </summary>
        /// <value>
        /// The invoice number.
        /// </value>
        public string InvoiceNum { get; set; }
        /// <summary>
        /// Gets or sets the total charge.
        /// </summary>
        /// <value>
        /// The total charge.
        /// </value>
        public string TotalCharge { get; set; }
        /// <summary>
        /// Gets or sets the invoice date.
        /// </summary>
        /// <value>
        /// The invoice date.
        /// </value>
        public string InvoiceDate { get; set; }
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public List<char> Items { get; set; }
    }
}