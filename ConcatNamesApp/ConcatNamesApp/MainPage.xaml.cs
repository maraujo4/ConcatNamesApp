using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConcatNamesApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{            
			InitializeComponent();
            ButtonConcat.Clicked += ButtonConcat_Clicked;
		}

        private void ButtonConcat_Clicked(object sender, EventArgs e)
        {
            try
            {
                LabelResult.Text = $"{EntryFirstName.Text} {EntryLastName.Text}!";
            }
            catch (Exception ex)
            {
                LabelResult.Text = ex.Message;
            }
        }
    }
}
