using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Sample;
using XLabs.Sample.Services;

namespace XLabs.Sample.ViewModel
{
    public class LoginViewModel : Forms.Mvvm.ViewModel
    {
        public LoginViewModel()
        {

            var _loginService = new LoginService();
            this.LoginCommand = new Command(async (nothing) =>
            {
                var result = await _loginService.LoginAsync(Username, Password);
                if (result.USER_ID > 0)
                {

                    Application.Current.Properties["USER_ID"] = result.USER_ID;

                    //await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    //await Navigation.DisplayAlert("错误", "输入的用户名或密码错误！", "确定");
                }

            });
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public int USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_NAME_EN { get; set; }
        public string USER_PWD { get; set; }
        public Nullable<int> DEPT_ID { get; set; }
        public string DEPT_NAME { get; set; }
        public Nullable<int> ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public string USER_EMAIL { get; set; }
        public Nullable<int> companyid { get; set; }
        public string companyname { get; set; }
        //public ICommand LoginCommand { get { return new SimpleCommand(Login); } }
        public ICommand LoginCommand { private set; get; }
        //private readonly IAppNavigation _navigationService;
        private ContentPage _page;


    }
}
