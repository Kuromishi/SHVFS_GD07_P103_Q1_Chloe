1.The difference between Update, Fixed Update and Late Update and when we should use each£¿
The same:When the monobehavior is enabled, it will be called in each frame. Used to update.
The difference: The time of each frame of 'update' is not fixed, the time T1 of the first frame and the second frame are not necessarily the same. 
Fixedupdate() the time difference between each frame is fixed.
the time interval when update is called will change. However, fixedupdate is not affected by the change of frame rate. 
It is called at fixed time intervals.
Therefore, some physical attribute update operations should be operated in fxiedupdate, such as force, Collider, rigidbody, etc.

LateUpdate()
Lateupdate is called after all update function calls. Can be used to adjust the order of script execution. 
For example, when an object moves in update, the camera following the object can be implemented in lateupdate.

2.What the streamingAssets folder is used for
Make the asset available as a separate file in its original format.

3."Special folder"
Resources
Load Assets on-demand from a script instead of creating instances of Assets in a Scene for use in gameplay. 
By placing the Assets in a folder called Resources. Load these Assets by using the Resources.Load function.
Have multiple Resources folders placed anywhere inside the Assets folder. 

4.The script execution order
TMPro.TextContainer
TMPro.TextMeshPro
TMPro.TextMeshProUGUI
UnityEngine.InputSystem.PlayerInput