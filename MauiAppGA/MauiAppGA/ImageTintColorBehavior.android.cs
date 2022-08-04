using Android.Widget;

namespace MauiAppGA;

public partial class ImageTintColorBehavior : PlatformBehavior<Image, ImageView> // Note the use of ImageView which is an Android-specific API
{
    protected override void OnAttachedTo(Image bindable, ImageView platformView) =>
        ImageExtensions.ApplyColor(platformView, TintColor);

    protected override void OnDetachedFrom(Image bindable, ImageView platformView) =>
        ImageExtensions.ClearColor(platformView);
}
