# Hello, CloudFront!

This is the code project for the [Hello, CloudWatch!](https://davidpallmann.hashnode.dev/hello-cloudwatch) blog post. 

This episode: Amazon CloudFront and content delivery networks. In this Hello, Cloud blog series, we're covering the basics of AWS cloud services for newcomers who are .NET developers. If you love C# but are new to AWS, or to this particular service, this should give you a jumpstart.

In this post we'll introduce Amazon CloudFront and use it in a "Hello, Cloud" .NET website to globally distribute content. We'll do this step-by-step, making no assumptions other than familiarity with C# and Visual Studio. We're using Visual Studio 2022 and .NET 6..

## Our Hello, CloudFront Project

We will deploy a simple website with an image and set up a CloudFront distribution for it. The website will always return a unique response, and the images will rarely change. We will set up cache behaviors that cache images for an hour at a time but never cache the website pages . We'll confirm CloudFront's cache behaviors by modifying images in S3 and noting how much time elapses before the updated editions are served to a site visitor.

See the blog post for the tutorial to create this project and run it on AWS.

# Image Attribution

The two sample images in this project were obtained from Wikimedia Commons, with the links, sources, and licenses noted below.

Image 1: [Blue Sky Sunny Sky Scenery - KH Fajla Rabby.jpg](https://commons.wikimedia.org/wiki/File:Blue_Sky_Sunny_Sky_Scenery_-_KH_Fajla_Rabby.jpg)

Author: KH Fajla Rabby

License: [Create Commons Attribution-SjareAlike 4.0 International](https://creativecommons.org/licenses/by-sa/4.0/deed.en)

Image 2: [Lightning cloud to cloud (aka).jpg](https://commons.wikimedia.org/wiki/File:Lightning_cloud_to_cloud_(aka).jpg)

Author: André Karwath aka Aka

License: [Creative Commons Attribution-Share Alike 2.5](https://creativecommons.org/licenses/by-sa/2.5/)
