using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        

        private readonly ApplicationContext context;
        public BaseForm(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();

            AddContact.Click += (sender, args) => Invoke(AddContact_Click);
        }

        public new void Show()
        {
            context.MainForm = this;
            Application.Run(context);
        }

        string ListContact
        {
            get
            {
                return ListOfContacts.Text;
            }
        }
        public event Action AddContact_Click;

        public void ShowError(string errorMessage)
        {
            lblError.Text = errorMessage;
        }

        private void Invoke(Action action)
        {
            action?.Invoke();
        }
    }
}
