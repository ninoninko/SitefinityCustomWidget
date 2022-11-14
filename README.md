# Sitefinity Custom Widget
## Overview
In the following repository I have posted a piece of code which I have made during my internship at Progress Software, Sofia. The base idea is that I am using a running instance of Sitefinity CMS in which I have created a custom widget which consumes the [SpaceX API](https://github.com/r-spacex/SpaceX-API) and shows the users specifically selected information from the API.

## Prerequisites
To use the custom widget, you need to build the source code of Sitefinity CMS. Make sure that your development system meets the following minimal requirements:

* A valid Sitefinity CMS license.
* Sitefinity CMS 14.1 or later.
* Your setup must comply with the minimum system requirements. For more information, see the System requirements for the Sitefinity CMS version you are using [here](https://www.progress.com/documentation/sitefinity-cms/system-requirements).
* Visual Studio 2015 or later.

## Building the solution
For the build of the solution I will assume that you are using Visual Studio 2019 but the process is similar with other versions of the IDE.

1. For the setup of Sitefinity CMS you can use the following [link](https://www.progress.com/documentation/sitefinity-cms/install-sitefinity).
2. Next you will have to pull the code from the repository and put it in the same folder as the <nameOfYourProject>.sln.
3. Reference the widget assembly from your main one.
4. Enjoy our SpaceX functionality!

## How does it work

The idea is quite straightforward. When you have set up an instance of Sitefinity and add the widget from: Content -> Custom -> SpaceX Flights on a page you have created, information about recent flight from the company will be shown for the user to pick from. After the user chooses a specific flight and clicks on it, additional information will be shown.
