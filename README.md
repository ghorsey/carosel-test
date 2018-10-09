# Interview Test project

A simple project to pull images from reddit and display them within a carousel.

## Pulling Images

* `https://www.reddit.com/r/pics.jsonhttps://www.reddit.com/r/pics.json`: to pull the first n number of images

## Guidance

1. Use dotnet core to fetch the image data from the above URL.  Filter the data to only include images which have content.
2. Send a smaller JSON structure from the front-end  returning the following JSON structure:

       {
           'title': 'some title',
           'imageSrc': 'http://some.url'
       }
