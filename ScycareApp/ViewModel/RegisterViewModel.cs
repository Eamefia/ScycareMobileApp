using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System;
using Twilio;
using Twilio.Rest.Verify.V2.Service;
using Twilio.Rest.Api.V2010.Account;

namespace ScycareApp.ViewModel;

public partial class RegisterViewModel : ObservableObject
{
    public RegisterViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;


    [ObservableProperty]
    string number;

    [ICommand]
    async Task SendCodeAsync()
    {

        //string accountSid = "AC5d7e7ab45da6cffdee488acd4e72e17a";
        //string authToken = "b3ff7b7cd263535ba1a603e54d010b34";
        //string countrycode = "+233";

        //TwilioClient.Init(accountSid, authToken);

        //var verification = VerificationResource.Create(
        //    to: countrycode + Number,
        //    channel: "sms",
        //    pathServiceSid: "VA7120f2659c564327dc20c38bec6553b0"
        //);

        //await Shell.Current.GoToAsync($"{nameof(VerifyCode)}?Number={Number}");
        await Shell.Current.GoToAsync(nameof(VerifyCode));


        Items.Add(Number);

        Number = string.Empty;
        
    }
}
