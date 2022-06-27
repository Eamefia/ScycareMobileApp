using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Twilio;
using Twilio.Rest.Verify.V2.Service;

namespace ScycareApp.ViewModel;

[QueryProperty(nameof(Number), nameof(Number))]

public partial class VerifyCodeViewModel : ObservableObject
{
    [ObservableProperty]
    string otpcode;

    [ObservableProperty]
    string number;

    [ICommand]
    async Task Verify()
    {
        //string accountSid = "AC5d7e7ab45da6cffdee488acd4e72e17a";
        //string authToken = "b3ff7b7cd263535ba1a603e54d010b34";
        //string countrycode = "+233";

        //TwilioClient.Init(accountSid, authToken);

        //var verificationCheck = VerificationCheckResource.Create(
        //    to: countrycode + Number,
        //    code: Otpcode,
        //    pathServiceSid: "VA7120f2659c564327dc20c38bec6553b0"
        //);
        //if (verificationCheck.Status == "approved")
        //{
        //    await Shell.Current.GoToAsync($"{nameof(Register)}?Number={Number}", false);
        //}
        await Shell.Current.GoToAsync(nameof(Register));

    }
}
