# Tutorial de Twilio - Proyecto 2
Laboratorio 3 - Investigación APIs - Grupo ANT-BEE

Documentación y librería: https://www.twilio.com/docs/libraries/csharp-dotnet

Más info: https://www.twilio.com/docs/sms/tutorials/how-to-send-sms-messages-csharp

Tutorial en Youtube de autoría propia: https://youtu.be/YGzwAY9V-fY




DOCUMENTACION LENNER/SEBAS

Que es Twilio?
- Twilio es un API que permite a los desarrolladores construir aplicaciones de comunicación en la nube y sistemas web.  Las API en comunicación de Twilio permiten a las empresas y desarrolladores proporcionar la experiencia de comunicación adecuada para los clientes dentro de la web y las aplicaciones móviles. Al usar el API de Twilio, los desarrolladores pueden agregar rápidamente esta funcionalidad a la aplicación, como mensajes de voz, videollamadas, mensajes de texto y más. Entre los API que ofrece Twilio se encuentran los siguientes: 

  SMS programables: Este API sirve para enviar y recibir mensajes de texto globalmente.

  Twilio SendGrid: Este API sirve para diseñar y enviar correos electrónicos flexibles junto con herramientas de marketing.

  Programable Video: Este API sirve para la creación de videos en tiempo real y audio HD utilizando WebRTC utilizando la infraestructura    de la nube.

  Twilio API for WhatsApp: Este API sirve para enviar y recibir mensajes de texto globalmente pero en WhatsApp.

  Programable Voice: Este API sirve para la construcción de conversaciones desde cualquier logar recibiendo o enviando llamadas en todo   el mundo.

  Programable Chat: Este API permite agregar chat a cualquier aplicacion con SDK para mobiles y web.

  Programable Fax: Este API permite enviar y recibir faxes entre su aplicacion y una maquina de fax.

¿Para qué sirve?
-Twilio toma la red global de comunicaciones y proporciona API de comunicación en la nube que se integra con los sistemas y aplicaciones web. Además, ayuda a las empresas a obtener la información correcta para sus clientes, junto con una conexión con la persona adecuada. También ayuda a llevar a los negocios a un nivel superior y a que los clientes participen y queden satisfechos.

Requisitos
-El telefono, para recibir y enviar mensajes debe de estar registrado en la pagina de Twilio.
-Necesita el Nuget "Twilio" en visual studio o plataforma de desarollo escogida.
-Se necesita un ID suministrado por Twilio.
-Se necesita un out token suministrado por Twilio.

¿Cómo se usa?

-Como primer paso debemos ingresar a la documentación de cómo usar Twilio en C#.

https://github.com/iStaack/cenfo_proyecto2_tuto_twilio/issues/1#issue-454453450

- Después se debe crear un nuevo proyecto de tipo consola.

https://github.com/iStaack/cenfo_proyecto2_tuto_twilio/issues/2#issue-454453780}

- Antes de poder comenzar a programar, deberá registrar su cuenta en Twilio. Después de haber registrado su cuenta deberá confirmar un mensaje que la página de Twilio envía a su correo para poder utilizarlo.

https://github.com/iStaack/cenfo_proyecto2_tuto_twilio/issues/3#issue-454454533

- Cuando haya recibido el correo aparecerá las siguientes opciones, en la cual deberá seleccionar cualquiera de las dos opciones para activar su cuenta.

https://github.com/iStaack/cenfo_proyecto2_tuto_twilio/issues/4#issuecomment-500666299

- Luego de haberse activado la cuenta deberá de ingresar el numero al cual Twilio enviará mensajes, si el numero al que se intenta enviar mensajes no está registrado en la página este no recibirá mensajes.

https://github.com/iStaack/cenfo_proyecto2_tuto_twilio/issues/5#issue-454456100

- Recibirá un código por mensaje al número ingresado para que verifique que el numero sea correcto.

https://github.com/iStaack/cenfo_proyecto2_tuto_twilio/issues/6#issue-454456388

- Deberá seleccionar las siguientes opciones para continuar con el proceso de usar Twilio en un entorno de desarrollo preferido.

https://github.com/iStaack/cenfo_proyecto2_tuto_twilio/issues/7#issue-454456841

- Luego de haber terminado el formulario se le mostrara el siguiente dashboard donde se mostrarán las siguientes credenciales que se usaran para el funcionamiento del API.

https://github.com/iStaack/cenfo_proyecto2_tuto_twilio/issues/8#issue-454457185

- Después de haber obtenido el número de pruebas de Twilio deberá ingresar el siguiente código.

https://github.com/iStaack/cenfo_proyecto2_tuto_twilio/issues/9#issue-454457676

-Luego para poder continuar necesitaremos un número de teléfono, el cual será suministrado por los servidores de Twilio, este número será el encargado de él envió de los mensajes. Por motivos de seguridad Twilio lo hace de esta manera.

- Por ultimo se deberá crear el siguiente código en el proyecto de tipo consola que se habia creado al pricipio.

https://github.com/iStaack/cenfo_proyecto2_tuto_twilio/issues/11#issue-454458262


Donde encontrar la documentación

- https://www.twilio.com/docs/libraries/csharp-dotnet
- https://www.twilio.com/docs/sms/tutorials/how-to-send-sms-messages-csharp

Nugets recomendados

-Twilio by Twilio.


Imagen del resultado:

![prueba](https://user-images.githubusercontent.com/47118987/59235571-34a0c580-8baf-11e9-8539-dda68d806f58.jpg)
