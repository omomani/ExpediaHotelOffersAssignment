# ExpediaHotelOffersAssignment

Website URL:
https://expediahoteloffers.azurewebsites.net/hotelofferspage.aspx

This site is a single page application that consume JSON API that represents a bunch of hotel deals provided by Expedia, the call is done as server call as requested.

To set up the website and run you need to:

  *Modify the tag <HotelOffersAPIURL> in web.config and set the correct URL of the API you want to consume.
  *Run the tests under the project ExpediaHotelOffers.Tests
  *If all went well, host the application on the cloud using any .net supported cloud hosting services.
  *or Host the application on IIS on a physical web server.

I have assumed that the API is always up and never goes down, and also that I dont need to know how it returns data, I assumed it is tested and is working just as Expedia wants it to work for the assignment purposes. Also I have assumed that the runtime environment where I would host my application (Heroku) supports .net websites and this assumption was not right at the end (this is explained int About.md).

Known issues:
  *The application is hosted on Windows Azure rather than Heroku (you can check the file About.md to see why I chose so)
  *The page doesn't have the sort feature
  *The page needs design and layout enhancements
