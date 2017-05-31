The difference between DateTime and NSDate are a lot bigger than i thought.
Not only that you have to be careful because DateTime could be either LocalTime or UTC, there is also some strange behaviour when changing the TimeZone.

When reloading the view, NSDate does everything as you expect.
When you want that DateTime also recognizes the new Timezone you have to perform 'TimeZoneInfo.ClearCachedData()'.

I thought Xamarin.iOS would handle that for me ... or not.