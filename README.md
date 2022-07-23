# VR-NPC

Framework for creating non-player characters in VR with social presence and emotions.

# Development diary and commits are in Spanish

*23/7/2022* Borré lo que había en el repositorio y subí lo que me pasó Rafael Márquez pero actualizado a Unity 2021.
Hubo que actualizar el proyecto meticulosamente, pues hubo un par de errores de compilación. Se corrigieron (XRDevide.ispresent estaba obsoleto y había que usar un código alternativo: https://docs.unity3d.com/ScriptReference/XR.XRDevice-isPresent.html) y así se pudo terminar la actualización. También se cambió el código de los shaders, que usaba una URP antigua. Al terminar seguí las instrucciones para que empezase a funcionar bien en mi Oculus Rift normal: https://docs.unity3d.com/Manual/configuring-project-for-xr.html
Lo de Setting up tracking in the VR plugin framework no hizo falta, porque el XR Rig parecía ya estar bien puesto.
Aún así quedan muchos warnings y mejoras pendientes. Como actualizar Behavior Designer y otros paquetes que se están usando. O usar una herramienta para limpiar archivos que no se usan: https://assetstore.unity.com/packages/tools/utilities/maintainer-32199
Actualicé también el gitignore.

¡Ojo! Se activó el cajón de arriba (closet3) para que ya esté abierto... porque en mi caso no conseguía abrirlo con la llave (algo del exclusivesocket, imagino que tendrá que ver con las manos/controladores, no me está yendo bien)
