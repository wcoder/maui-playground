namespace MauiAppGA;

public class ImageTintColor : Image
{
    public static readonly BindableProperty TintColorProperty =
        BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(ImageTintColor), propertyChanged: OnTintColorChanged);

    public Color? TintColor
    {
        get => (Color?)GetValue(TintColorProperty);
        set => SetValue(TintColorProperty, value);
    }

    static void OnTintColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (ImageTintColor)bindable;
        var tintColor = control.TintColor;

        if (control.Handler is null || control.Handler.PlatformView is null)
        {
            // Workaround for when this executes the Handler and PlatformView is null
            control.HandlerChanged += OnHandlerChanged;
            return;
        }

        if (tintColor is not null)
        {
#if ANDROID
            // Note the use of Android.Widget.ImageView which is an Android-specific API
            ImageExtensions.ApplyColor((Android.Widget.ImageView)control.Handler.PlatformView, tintColor);
#elif IOS
            // Note the use of UIKit.UIImage which is an iOS-specific API
            ImageExtensions.ApplyColor((UIKit.UIImageView)control.Handler.PlatformView, tintColor);
#endif
        }
        else
        {
#if ANDROID
            // Note the use of Android.Widget.ImageView which is an Android-specific API
            ImageExtensions.ClearColor((Android.Widget.ImageView)control.Handler.PlatformView);
#elif IOS
            // Note the use of UIKit.UIImage which is an iOS-specific API
            ImageExtensions.ClearColor((UIKit.UIImageView)control.Handler.PlatformView);
#endif
        }

        void OnHandlerChanged(object s, EventArgs e)
        {
            OnTintColorChanged(control, oldValue, newValue);
            control.HandlerChanged -= OnHandlerChanged;
        }
    }
}

