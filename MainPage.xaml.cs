namespace WhenCanILegallyBuyAlcoholApp;

public partial class MainPage : ContentPage
{

	private Dictionary<string, int> countryAgeLookup =
		new Dictionary<string, int>(){
			{"US of the A", 21},
			{"Netherlands", 18},
			{"Ireland", 18},
			{"Cuba", 16},
			{"Paraguay", 20}
		};

	// DateTime SelectedDate = DateTime.Today;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this; // For the SelectedDate of the DatePicker

		foreach(KeyValuePair<string, int> countryAge in countryAgeLookup)
		{
			SelectCountry.Items.Add(countryAge.Key);
		}

	}

	private void OnUpdatePurchaseParameters(object sender, EventArgs e)
	{
		if(SelectCountry.SelectedItem != null){
			var selectedCountryKey = (string)SelectCountry.SelectedItem;

			if(selectedCountryKey != "null"){
				var onDate = BornDatePicker.Date.AddYears(countryAgeLookup[selectedCountryKey]).ToLongDateString();
				AlcholBuyLabel.Text = $"You will be able to buy alcohol on {onDate} at the age of {countryAgeLookup[selectedCountryKey]}.";
			}
		}


	}


	private void OnCounterClicked(object sender, EventArgs e)
	{
		// count++;

		// if (count == 1)
		// 	CounterBtn.Text = $"Clicked {count} time";
		// else
		// 	CounterBtn.Text = $"Clicked {count} times";

		// SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

