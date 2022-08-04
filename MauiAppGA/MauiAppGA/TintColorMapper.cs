using Microsoft.Maui.Handlers;

namespace MauiAppGA;

public static class TintColorMapper
{
    public static readonly BindableProperty TintColorProperty =
        BindableProperty.CreateAttached("TintColor", typeof(Color), typeof(Image), null);

    public static Color GetTintColor(BindableObject view)
        => (Color)view.GetValue(TintColorProperty);

    public static void SetTintColor(BindableObject view, Color value)
        => view.SetValue(TintColorProperty, value);

    public static void ApplyMapper()
    {
        ImageHandler.Mapper.Add("TintColor", (handler, view) =>
        {
            if (handler.VirtualView is null || handler.PlatformView is null)
                return;

            var tintColor = GetTintColor((Image)view);

            if (tintColor is not null)
            {
#if ANDROID
                // Note the use of Android.Widget.ImageView which is an Android-specific API
                ImageExtensions.ApplyColor(handler.PlatformView, tintColor);
#elif IOS
                // Note the use of UIKit.UIImage which is an iOS-specific API
                ImageExtensions.ApplyColor((UIKit.UIImageView)handler.PlatformView, tintColor);
#endif
            }
            else
            {
#if ANDROID
                // Note the use of Android.Widget.ImageView which is an Android-specific API
                ImageExtensions.ClearColor(handler.PlatformView);
#elif IOS
                // Note the use of UIKit.UIImage which is an iOS-specific API
                ImageExtensions.ClearColor((UIKit.UIImageView)handler.PlatformView);
#endif
            }
        });
    }
}

