#Light
This framework is designed to support WPF MVVM pattern and make it to fit DDD.

##Principal
We all know we have a framekwork called Prism to support MVVM development for WPF/SL, but it's too heavy. We want to build a light framework not so fancy but useful for who only want their application MVVM-able. 

##Scope
Our scope for this is MVVM support, Logging support, WCF integration support and EF integration support.
We want it support Domain Driven Design pattern.
And we want it have the VM driven GUI autogeneration ability for fast application built or unit test support. 

##General Though
We want to have the domain thing in VM way and generate GUI from the VM. 
It will have the ablility on load DLLs on demond and "Inner Path" support.

###Inner Path
Should be a string like "app/main/login" which means login window or "app/main/createblog" means a blog creation part of the app. We want the user can create a shortcut for the specific part of application. When user re-open it, it will show directly to that specific part.

##Development Schedule
We don't have a deadline for this, so don't expect us can relase a workable version in recent. 
And I think we can have a version in 2 monthes. 
 