using UIKit;

namespace MauiAppGA;

public partial class ImageTintColorBehavior : PlatformBehavior<Image, UIImageView>
{
    protected override void OnAttachedTo(Image bindable, UIImageView platformView)
    {
        ImageExtensions.ApplyColor(platformView, TintColor);
    }

    protected override void OnDetachedFrom(Image bindable, UIImageView platformView)
    {
        ImageExtensions.ClearColor(platformView);
    }
}