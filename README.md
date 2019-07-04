# Right-To-Left example of Xamarin.Forms ListView

The ListView supports to change the flow of text to the right-to-left direction by setting the [FlowDirection](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.visualelement.flowdirection?view=xamarin-forms#Xamarin_Forms_VisualElement_FlowDirection) to `RightToLeft` in both `Vertical` and `Horizontal` orientations. ListView supports RTL in Xamarin.Forms version 3.0 and above. It also supports RTL when device's flow direction is changed.

```xml
<ContentPage  xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
    <ContentPage.Content>
       <syncfusion:SfListView x:Name="listView" FlowDirection="RightToLeft"/>
    </ContentPage.Content>
</ContentPage>
```

You can also refer our UG documentation to know more about [RTL]().
