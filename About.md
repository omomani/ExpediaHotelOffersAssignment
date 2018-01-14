
Website URL:
https://expediahoteloffers.azurewebsites.net/hotelofferspage.aspx

In this simple website I want to consume JSON API that represents a bunch of hotel deals provided by Expedia, and to display the results in a simple easy-to-understand manner, I have thought to make the results look informative wile displaying the least possible data to the user as recommended in UX field users need to get useful info in minimum time and effort so that the way we present our data affects our customers' satisfaction very much.

This site was built to make server side calls to get the data as per Expedia's request, while in fact I would have preferred if we built the application in one of the front-end frameworks such as Knockout, AngularJS, etc with AJAX call to get the data from the API provided and also we can make sure that each call is not from a cached list.

The design and layout of the page is not that important (as advised) so please excuse my poor colored and designed page, yet I have focused on displaying the adequate info needed with links to hotels and google maps for locations. for the features in the page, I have only implemented search function and display list, other features like sorting were not added.

Another features include redirecting customers to hotel-specific details page when clicking on the hotel name, and showing the location of the hotel on google maps when you click on the location icon or the city-region text.

Having my experience is mostly in Microsoft technologies, so I used ASP.Net with VB.Net as backend code (I have asked if it is allowed to use them, and I got the approval before I started).

Technologies used in the Site:
  MS.Net: Experienced
  HTML: Experienced
  JS or Jquery: Experienced
  Github: First time
  Heroku: First time

It is my first time to use Github but I like it very much and I want to use it in some tutorials in future to keep my code there, I managed to learn the Github repositories, master branch, branches, pull requests, merge and other features, the whole thing is awesome.

It is my first time to use Heroku and I had big problems here, Heroku doesn't officially support .net websites, and I truly had very tight deadline to deliver the assignment and I contacted the HR to postpone the date as I have critical deadlines with heavy workload in the 4-day time of the assignment, however, if I had more time I would have thought of building the website again in other language (Java or PHP) once I figured out Heroku doesn’t support .net, I am able to learn a new language and build the website again as it is a simple one but I truly didn't find enough time originally to build it in .net. So I tried hardly to find out a solution and I learned that Heroku has additional build packs that are not officially supported but they can work, one of the buildpacks I found was able to host .net websites to Heroku, and when I started figuring out how it works and implementing the hosting process, I was faced in a new problem which is hosting a website on Heroku doesn't only need a custom buildpack for .net, yet it also needs that the website is cross platform and in order to achieve that Microsoft launched .net core which is a cross platform framework to run over windows, mac, linux, .. etc. I have downloaded the latest version of Visual Studio and downloaded .net core to build a new website under .net core, but again .net core websites are either Razor or MVC which is not the same as my website and I never used .net core before so I didn't have time to learn and build the new website. However, in order to finish the assignment I have hosted my website on Windows Azure not on Heroku due to limited available time.

During this exercise I have learnt:
  GitHub services
  Heroku services and buildpacks, and that it doesn't support Microsoft websites officially
  .Net Core framework, and how to create cross platform applications using .net
  And all the above done in one day as I was engaged in heavy workload in my work during the assignment given time.
  
Note: I will be able to resubmit my website after I manage to rebuild it using .net core and hosting it on Heroku, but this needs more time as I mentioned before and I can do it during the weekend.

Regards,
Osama Momani,
Software Development Architect and Engineer
