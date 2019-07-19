# Dispatcher.RunAsyncを使用する

```c#
                await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
        button.IsEnabled = true;
                });
```