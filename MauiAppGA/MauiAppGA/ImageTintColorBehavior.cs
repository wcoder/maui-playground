namespace MauiAppGA;

public partial class ImageTintColorBehavior
#if !(ANDROID || IOS || MACCATALYST)
	: PlatformBehavior<Image>
#endif
{
    public static readonly BindableProperty TintColorProperty =
        BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(ImageTintColorBehavior));

    public Color TintColor
    {
        get => (Color)GetValue(TintColorProperty);
        set => SetValue(TintColorProperty, value);
    }
}
