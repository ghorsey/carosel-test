# Interview Test project

A simple project to pull images from reddit and display them within a carousel.

## Pulling Images

* `https://www.reddit.com/r/pics.json`: to pull a list of images

## Guidance

1. Use dotnet core to fetch the image data from the above URL.  Filter the data to only include images which have content.
2. Create a RESTful GET endpoint @ `/api/pics`
3. Send a smaller JSON structure to the front-end  returning the following JSON structure:

       {
           'title': 'some title',
           'imageSrc': 'http://some.url'
       }
4. Create a carousel component in Angular that scrolls through the images.