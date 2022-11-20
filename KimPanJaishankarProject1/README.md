## Milestone 3 Documentation and Compilation Instructions

Github Repository Link: https://github.com/heki5656/CSCI4616_Project/tree/main/KimPanJaishankarProject1

1. Unity version: 2021.3.9f1

2. To run the project, you need an android phone and put it on developer mode so that you can build the apk file to the phone and build to all compatible devices.

    - To build the project, go to the project settings and build an apk file to android. Then you can just build and run 
3. If there is a build error, there is a generated file that does not create a new line for one of them, so you need to go to this file path: ...\KimPanJaishankarProject1\Library\Bee\Android\Prj\IL2CPP\Gradle\unityLibrary and open build.gradle and on line 9 just create a new line for that incorrectly indented code line. 

    - We're not sure why this always happened but we couldn't figure out how to stop unity from doing this either so easiest method is as listed above
Goal we are trying to achieve: We are attempting to duplicate a crime scene based on a real scenario ideally, but for this project we made a focus on developing a virtual environment and learning how we would be able to interact with it using limited materials. For instance, we allow for more accessiblity by using a Google Cardboard rather than a standard headset which is less available cost wise to the general public. We wanted to develop an environment that is easy to view and understand. For instance, one of the interactive elements, the hover and text appear feature, is something that instataneously appears while the user is just looking around. This is a feature we included since the Cardboard is limited without the joycons that allow for touch interactivity other than the screen. We also included free assets of objects that are typically found in a standard home, such as the dining table and chairs. These are useful if there are any crime scenes that occurred in a home and we wanted to create one of the rooms that had these assets. And of course we included blood, as the majority of homicide cases there are blood spills and we wanted to be able to incorporate blood splatters for the user to understand the crime better. We hope to allow the user to understand the details of a crime scene without having to be physically present. 

    - This experience we've created aims to allow users to interact with typical objects of interest in a crime scene by simply viewing/gazing and eventually tapping the object to see it's contents. Users would hopefully be able to find their way around the scene with our navigation and selection techniques through popup displays, camera gaze, and glow effects. 

The following sections describe our techniques more in depth and also includes our user experience comparison.

- (Navigation) Our first navigation in our project is a popup display that is in the form of an exclamation mark above the fallen chair. We wanted to make the fallen chair one of the main focuses, and to redirect the user to look at it we had this since it is just hovering and seemingly out of place. As a result, they would get interested to look at the chair below the exclamation point. 

- (Selection/Manipulation) Our selection and navigation options were limited since we are using a google cardboard, so we did a focus on the gaze of the camera inside the virtual room. When the user focuses the camera to be placed on the floating exclamation point, it should be transformed into a much more clear text that is a description of what made this part of the room important in the crime scene. This is the type of interaction we have chosen to integrate given out limited options of lack of controllers. 

- (Navigation) Our other navigation technique is the glowing areas for our crime scene. Since the virtual environment is primarily dark, the glowing areas help the user determine what they should be looking at and find the objects of focus more easily in the scene. And glowing things tend to draw a person's eye, so we thought this was the best for of 'bread crumbs' that would draw the user into looking at those specific areas. 

- (User Experience Comparision) 

    _User #1:_

    Question: What do you like about our project as it is and what can we change - in general and specifics? For example, we have a technique for allowing users to navigate through the simulation and we are doing this by making certain objects glow. Does this approach seem intuitive and/or how can we improve it? 

    Feedback from Lakshya’s roommate (Mackenzie): “This is a very interesting idea and looks like it has some very useful applications. I love the educational component you bring into this project. I could see it being a very handy tool for those interested in law or criminology. It would be nice to have more interactivity since right now, I have a way of identifying what objects to review in the scene but because investigators usually have to physically collect evidence, it could be helpful to model that more in this simulation by having more objects to click on than what is currently existing. I also like that you made certain objects glow as a way to form a path for users to move to and analyze them. One thing that could potentially be enhanced is the way in which the objects are glowing since they are popping a lot right now.”

    Reflection: Based on my roommate’s feedback, I think one way to enhance the project would be by changing the glow effect to be a little less intense as there is currently a bright square around the object in question in addition to the glow. This makes the object stand out a lot which can be toned down a little. We plan to test out other approaches to making the object glow more naturally. Finally, in order to add a little more interactivity in addition to our current user interaction, one idea we had which we would like to implement would be by making a window glass shatter on tap or gaze. This will offer another component in making the user feel a little more immersed in the scene and get a better understanding of the crime. 

    _User #2:_
    
    Question: What are your initial thoughts when walking through our project? What do you like about our project? What are some things that we can improve on?

    Feedback from Luke’s roommate (Kyle): “Overall, I like the project. I think that it’d be useful in the real world. I think it's a good idea that the project is accessible using a phone because then multiple users can use it at the same time without the use of many expensive VR headsets. I think that the scene could be more immersive. Right now the room seems very closed off. Maybe adding a window or two could be good. Also I like the text popup but I think that it should be included on other objects as well.”

    Reflection: I think that from this feedback we can conclude that we are heading in the right direction with the project. However, it seems that the scene is lacking realness. Kyle’s suggestion to add a window could definitely be something to look into. We will also definitely need to add descriptions to other items - for example a description of the bloodstain describing what type of bloodstain it is and what it would indicate to a forensics professional.

