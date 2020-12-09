# Azure Computer Vision services

## Computer Vision API

1. **Intro**

   Computer Vision includes a bunch of the capabilities in terms of image analyzing.

   those includes:

   - extracting text from images using OCR
   - analyze images for characteristics and effects on them
   - tag images based on people and objects on the image
   - detect people and objects and location of them on the image
   - identify known brands on the images and videos
   - categorize images
   - detect faces
   - create a description of an image
   - there are many more endpoints for processing and recognizing data on the images.

2. **Use cases**

   Example use cases for Computer Vision API:

   - moderate explicit content on social media, forums etc.
   - digitalization of documents and hand written notes, signatures

3. **How to**

   1. Using the service
      
      1. Create cognitive service using the Portal, ARM template, Azure CLI or other tool
      2. Then you need to get Computer Vision `Subscription key`. 
      3. Then using this key you can authorize to use the API of this service. You can make requests using HTTP API with header named `Ocp-Apim-Subscription-Key`. 
      4. Another option to use Azure  Computer Vision API is to use the official SDK. The SDKs are available for: C#/.NET, Python, Node.js, Go and Java. In this approach the `Subscription key` is used as a parameter in the SDK methods and/or classes.
      
   2. Pricing

      1. Free tier

         The free tier comes with limitations. You can use only 20 transaction per minute, up to 5,000 transactions free per month

      2. Standard tier

         Standard tier comes with limit of 10 transaction per second. The pricing is as follows according to :

         | Feature names                                            | pricing                                                      |
         | -------------------------------------------------------- | ------------------------------------------------------------ |
         | Tag Face GetThumbnail Color Image Type GetAreaOfInterest | 0-1M transactions — $1 per 1,000 transactions 1M-5M transactions — $0.80 per 1,000 transactions 5M-10M transactions — $0.65 per 1,000 transactions 10M-100M transactions — $0.65 per 1,000 transactions 100M+ transactions — $0.65 per 1,000 transactions |
         | OCR Adult Celebrity Landmark Detect, Objects Brand       | 0-1M transactions — $1.50 per 1,000 transactions 1M-5M transactions — $1 per 1,000 transactions 5M-10M transactions — $0.65 per 1,000 transactions 10M-100M transactions — $0.65 per 1,000 transactions 100M+ transactions — $0.65 per 1,000 transactions |
         | Describe+ Read                                           | $2.50 per 1,000 transactions                                 |
         | Spatial analysis                                         | Free during preview                                          |

## Custom Vision

1. **Intro**

   Custom Vision lets you build your own machine learning models for image classification and recognition. It allows you to train ML model on your own images. That way you can detect specific objects better than using a general image recognition such as Computer Vision.

2. **Use cases**

   Example use cases for Custom Vision:

   - self-service checkout in a mall, shop, grocery store etc.
   - Detect rubbish types to sort them properly
   - detect car types on road to charge them propperly

3. **How to**

   1. Using the service

      1. Create cognitive service using the Portal, ARM template, Azure CLI or other tool
      2. Navigate to the http://customvision.ai/ where you can create new project and set the type (classification or detection) and the domain of the project. Here you can choose compact type of project. That allows to run project on IoT devices, smartphones etc.
      3. Images can be uploaded using custom vision portal or API/SDK.
      4. Model training and publishing could be done using API or custom vision portal
      5. Image recognition/classification could be done  using API/SDK. On the custom vision portal there is a option to test trained model.

   2. Pricing

      1. Free tier

         1. The free tier comes with limitations. You can use only 2 transaction per second, up to 2 projects, and up to 1 hour training per month. You can use 5,000 training images free per project and 10,000 predictions per month free per month.

      2. Standard tier

         1. Standard tier comes with limit of 10 transaction per second. The pricing is as follows:

            | Upload and prediction transactions (Up to 100 projects) | $2 per 1,000 transactions |
            | ------------------------------------------------------- | ------------------------- |
            | Training                                                | $20 per compute hour      |
            | Image Storage Up to 6 MB each                           | $0.70 per 1,000 images    |

## Video Indexer

1. **Intro**

   Azure Video Indexer is a service that allows to extract important information from video files, eg.: face detection, text recognition, scene division or extraction of elements visible on the video.

2. **Use cases**

   Example use cases for Video Indexer:

   - moderate explicit content on video
   - extract description what's going on on the movie for blind people
   - extract emotions from movie

3. **How to**

   1. Using the service
      
      1. Create cognitive service using the Portal, ARM template, Azure CLI or other tool
      2. Then you need to get Video Indexer `Subscription key`. 
      3. Then using this key you can authorize to use the API of this service. You can make requests using HTTP API with header named `Ocp-Apim-Subscription-Key`. 
      4. Another option to use Azure Video Indexer is to use the official SDK. The SDKs are available for: C#/.NET, Python, Node.js, Go and Java. In this approach the `Subscription key` is used as a parameter in the SDK methods and/or classes.
   2. Pricing
   
      The Video Indexer gives 10 free hours for indexing to website users and 40 free hours for indexing to API users. When moe hours needed user must attach Azure Media Services to Video Indexer.