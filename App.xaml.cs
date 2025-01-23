namespace dotnet_maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        // 앱이 처음 실행될 때 플랫폼별 수명 주기 이벤트를 재정의할 수 있음.
        //protected override void OnStart()
        //{
        //    base.OnStart();
        //}

        //protected override void OnResume()
        //{
        //    base.OnResume();
        //}

        //protected override void OnSleep()
        //{
        //    base.OnSleep();
        //}
        // 앱이 처음 실행될 때 플랫폼별 수명 주기 이벤트를 재정의할 수 있음.
    }
}
