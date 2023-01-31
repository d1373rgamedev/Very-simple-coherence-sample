# Very-simple-coherence-sample
A very simple coherence example scene for Unity
2021.3  

* [Log in to your coherence dashboard](#log-in-to-your-coherence-dashboard)
* [Clone repository](#clone-repository)
* [In Unity Hub, add project to unity](#in-unity-hub)
* [In Unity open the coherence hub](#in-unity-open-the-coherence-hub)
* [In coherence Portal, create a new world](#in-coherence-portal)
* [In Unity coherence Hub, build and upload the simulator](#in-unity-coherence-hub)
* [In coherence Portal, configure simulator](#in-coherence-portal)
* [Optional, buld and share as WebGL](#optional)  

![image](https://user-images.githubusercontent.com/99050073/215866805-c8313f05-2e19-4b67-bcfe-6d5250484ecc.png)  

### Log in to your coherence dashboard  
https://coherence.io/dashboard  
Create a Project, New Project, Project Name: Very simple coherence sample  
![image](https://user-images.githubusercontent.com/99050073/215840103-2350a3cd-9790-4db5-bc33-8920cb39c32e.png)  

### Clone repository
On your local system  
Clone repository to your disk  
Foldername e.g. Very simple coherence sample  

### In Unity Hub  
Add project from disk to Unity  
![image](https://user-images.githubusercontent.com/99050073/215840475-7ff5b49d-5c72-4bdb-9766-f15ee14ee4ee.png)  
Editor Version, everything with 2021.3 should be fine  
Open Project, open Sample Scene  

### In Unity open the coherence Hub  
Login to the Coherence Developer Portal  
Chhose your Organisation  
Choose Project "Very simple coherence sample"  
Bake Schema & Upload to coherence Cloud  
![image](https://user-images.githubusercontent.com/99050073/215839020-2c586453-d43a-479e-a5ca-36bcd821d2ab.png)  

### In coherence Portal  
Create a New World, Name e.g. Very simple coherence sample World  
![image](https://user-images.githubusercontent.com/99050073/215839371-288fdb3a-3621-45ab-931c-37021e445cb5.png)  

### In Unity coherence Hub  
Simulator, Build and Upload Headless Linux Client  
Simulator Slug e.g. NewFirstScene1  
![image](https://user-images.githubusercontent.com/99050073/215838319-d42f2500-b60e-48d0-b3e2-51395bf145c6.png)  
Mentioned that this should build a linux simulator because it later will be uploaded and runs in the coherence cloud.
![image](https://user-images.githubusercontent.com/99050073/215834634-8e6c8302-566b-4624-913e-9a900ad0d123.png)  
Just take a look in your Unity Hub, under your used unity version there you should see the linux modules to be installed.
if not you can add them ..
![image](https://user-images.githubusercontent.com/99050073/215834688-1b1027be-6a21-4287-b07a-8bb7d24ca121.png)  

### In coherence Portal  
Simulator Configuration  
Choose your simulator  
Portal, Rooms, Choose Regions  
![image](https://user-images.githubusercontent.com/99050073/215837792-739305e3-3fa5-4754-8d8b-85ab3b10b5d7.png)  
![image](https://user-images.githubusercontent.com/99050073/215836787-0553448c-6c61-4118-9a42-4586a0c26b16.png)  

### Optional:  
* In Unity  
Build WebGL  
![image](https://user-images.githubusercontent.com/99050073/215840911-115cc731-1303-4b9f-9a52-f7ae3864b2b9.png)  
then upload  
![image](https://user-images.githubusercontent.com/99050073/215842717-efa15170-b852-4d3c-85de-f12683fcffee.png)
* In coherence Portal  
Share Build  
Portal - Share Build, Public Page Enabled  
Use Link to open Sample Scene in Browser  
![image](https://user-images.githubusercontent.com/99050073/215841696-24029596-1d8a-4328-aabd-9d465e680a36.png)  

of course you can build and upload other clients as well  
![image](https://user-images.githubusercontent.com/99050073/215843220-a39d51d6-5bd3-40ad-9b01-7f7847c31ea1.png)
