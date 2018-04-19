﻿using System;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace DilipSample1
{    
    public class App : Application
    {        
        //public static IAuthenticate Authenticator { get; private set; }
        public App()
        {
            // The root page of your application
            MainPage = new TodoList();
        }        

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

