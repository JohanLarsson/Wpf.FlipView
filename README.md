# Gu.Wpf.FlipView

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md)
[![Build status](https://ci.appveyor.com/api/projects/status/tp8vm8xlvtakfat9/branch/master?svg=true)](https://ci.appveyor.com/project/JohanLarsson/gu-wpf-flipview/branch/master)

A flipview for WPF, handles touch &amp; mouse swipe.

# Table of contents
- [FlipView](#flipview)
  - [IncreaseInAnimation](#increaseinanimation)
  - [IncreaseOutAnimation](#increaseoutanimation)
  - [DecreaseInAnimation](#decreaseinanimation)
  - [DecreaseOutAnimation](#decreaseoutanimation)
  - [CurrentInAnimation](#currentinanimation)
  - [CurrentOutAnimation](#currentoutanimation)
  - [ShowIndex](#showindex)
  - [IndexPlacement](#indexplacement)
  - [IndexItemStyle](#indexitemstyle)
  - [ShowArrows](#showarrows)
  - [ArrowPlacement](#arrowplacement)
  - [ArrowButtonStyle](#arrowbuttonstyle)

# FlipView
A selector that transitions when selecteditem changes.
Has bindings to `NavigationCommands.BrowseBack` and `NavigationCommands.BrowseForward`

## IncreaseInAnimation
The animation to use for animating in new content when selected index increased.

## IncreaseOutAnimation
The animation to use for animating out old content when selected index increased.

## DecreaseInAnimation
The animation to use for animating in new content when selected index decreased.

## DecreaseOutAnimation
The animation to use for animating out old content when selected index decreased.

## CurrentInAnimation
The resulting animation to use for animating in new content.

## CurrentOutAnimation
The resulting animation to use for animating out old content.

## ShowIndex
If the index should be visible

## IndexPlacement
Where the index should be rendered

## IndexItemStyle
A style with `TargetType="ListBoxItem"` for how to render items in the index.

## ShowArrows
Specifies if navigation buttons should be visible.

## ArrowPlacement
Specifies where navigation buttons are rendered.

## ArrowButtonStyle
A style with `TargetType="RepeatButton"` for how to render navigation buttons.

Sample slideshow images:

```xaml
<flipView:FlipView SelectedIndex="0">
    <Image Source="http://i.imgur.com/xT3ay.jpg" />
    <Image Source="http://i.stack.imgur.com/lDlr1.jpg" />
</flipView:FlipView>
```

Sample bound itemssource:

```xaml
<flipView:FlipView x:Name="FlipView"
                    ItemsSource="{Binding People}"
                    SelectedIndex="0">
    <flipView:FlipView.ItemTemplate>
        <DataTemplate DataType="{x:Type local:Person}">
            <Border Background="#f1eef6">
                <TextBlock HorizontalAlignment="Center" VerticalAlignment="Center">
                    <TextBlock.Text>
                        <MultiBinding StringFormat="{}{0} {1}">
                            <Binding Path="FirstName" />
                            <Binding Path="LastName" />
                        </MultiBinding>
                    </TextBlock.Text>
                </TextBlock>
            </Border>
        </DataTemplate>
    </flipView:FlipView.ItemTemplate>
</flipView:FlipView>
```

