<center>
  <img src="https://raw.githubusercontent.com/wcoder/maui-playground/master/MauiApp1/MauiApp1/Resources/Images/dotnet_bot.svg?token=AAF3B4MS7LSQRR2E4UIVYKDBKRXZK" align="center" width="50%"/>
  <h1>MAUI Playground</h1>
</center>





## iOS

Available simulators:
```cs
xcrun simctl list
```

Run iOS project:
```sh
dotnet build -t:Run -f net6.0-ios -p:_DeviceName=:v2:udid=<SIMULATOR_UUID>
```
where `<SIMULATOR_UUID>` looks like `53767AF1-xxxx-xxxx-982E-DE9D702B526C`.

Run on iPhone 11:
```cs
dotnet build -t:Run -f net6.0-ios -p:_DeviceName=:v2:udid=$(xcrun simctl getenv "iPhone 11" SIMULATOR_UDID)
```
