# Xamarin.Android Bindings library project Rider bug sample

The only difference between `MicrosoftSdk` and `Standard` projects is `csproj` file. `Standard` project is generated mostly automatically (except wildcards in `ItemGroup` nodes), while `MicrosoftSdk` `csproj` was created manually, inspired by [Baseflow implementation of ExoPlayer Xamarin port](https://github.com/Baseflow/ExoPlayerXamarin). I think this approach is much better, since it makes `csproj` files much more readable and can support multiple target frameworks if needed. I guess there're also some other advantages as well.

So, main problems in Rider:
1. `MicrosoftSdkBindingsLibrary\Additions\StateProvider.cs` - everyting is red, Intellisense doesn't see files from `obj\$(Configuration)\$(TargetFramework)\generated\src` and `obj\$(Configuration)\$(TargetFramework)\generated\enums`.
2. `StandardBindingsLibrary\Additions\StateProvider.cs` - everyting is red, Intellisense doesn't see files from `obj\$(Configuration)\generated\src` and `obj\$(Configuration)\generated\enums`.
3. `SampleApp\MainActivity.cs` - same problem, Itellisense doesn't see generated files from the referenced project.
4. Other issue: Rider doesn't care what `TargetFrameworkVersion` is written in `csproj` file, it always picks 11.0 (R - API 30) as target API. Problem relates only to `StandardBindingsLibrary` project.

Compilation is successful for all projects.

Android Studio project is also included. You can compile it and change there something, `csproj` will pick a compiled aar automatically (there're conditions in `csproj` files which give such ability).
