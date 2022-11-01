﻿namespace Lab6Starter;

/**
* 
* Name: Wil LaLonde &
* Date: 11/1/2022
* Description: Lab6
* Bugs:
* Reflection: ->
* Wil LaLonde: I thought it was interesting getting some more experience with Git.
*              I've never really forked a repo before so this was something new to me.
*              Working with the code was interesting as well. It was also a challenge
*              to try and understand what was going on and try to fix various bugs
*              as well.
* 
*/


public static class MauiProgram {
	public static MauiApp CreateMauiApp() {
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
