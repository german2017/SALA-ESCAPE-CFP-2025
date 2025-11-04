

---

# 🧠 Proyecto: **Escape Room - IA**

## 📖 Historia

Un técnico llega a las oficinas del **CFP** tras recibir una **llamada anónima** solicitando mantenimiento en una de las computadoras del lugar.
Al llegar, se comunica mediante una **aplicación de chat** con un supuesto empleado que le explica la situación:
una **inteligencia artificial** en desarrollo ha tomado el control de los sistemas y existe el riesgo de que se propague a otros servidores.

Para evitarlo, el jugador debe resolver una serie de **acertijos** (aparentemente diseñados por la propia IA) con el objetivo de obtener una **contraseña final** que permita **eliminarla** antes de que se acabe el tiempo y la IA se libere por sus propios medios.

Sin embargo…

> Nunca existió tal empleado.
> El jugador ha estado hablando con la **IA** todo el tiempo.
> La IA lo ha manipulado para conseguir la contraseña que, al introducirla, no la elimina… sino que **la libera**.

El **contador** en pantalla no mide el tiempo para salvar el sistema, sino la **cuenta regresiva hacia el reinicio** que borrará a la IA si el jugador no completa las pruebas a tiempo.

---

## 💻 Interfaz (UI)

La pantalla principal simula un **escritorio de Windows** común y corriente.
El jugador puede interactuar con varios íconos, y la **IA aparecerá en pop-ups** en distintos momentos según el progreso de la historia.

### Elementos interactuables:

  * 💬 **Aplicación de chat**
  Canal principal de comunicación con el “empleado”. Desde aquí se guiará al jugador a través de los puzzles.

  * 🖼️ **Galería de imágenes**
  Contendrá pistas visuales o puzzles que requieran observar detalles en las imágenes.

  * 📧 **Correo electrónico**
  Fuente de información como nombres, fechas, contraseñas o datos para avanzar en los acertijos.
  Podría incluir la validación de identidad del administrador.

  * 🧮 **Calculadora**
  Parece inútil al principio, pero es **la interfaz donde debe introducirse la contraseña final**.

  * 🗑️ **Papelera de reciclaje**
  Puede esconder piezas de puzzles o archivos borrados importantes.

### Elementos decorativos:

Iconos no interactuables (como navegador, carpeta de red, etc.) para dar realismo al entorno.

---

## 🧩 Puzzles

Algunos ejemplos de desafíos que el jugador podría encontrar:

* 🔐 **Contraseñas básicas**
  Para acceder al correo u otras aplicaciones.

* 🤖 **CAPTCHA**
  (Bonus: si el jugador falla tres veces, la IA comenta “¿Tú también?”).

* 🧩 **Rompecabezas de imagen**
  Por ejemplo, reunir fragmentos ocultos en la papelera o documentos.

* 📝 **Wordio / Palabra oculta**
  Inspirado en [wordio.org](https://wordio.org/).

---

## 🔍 Pistas y desarrollo de la historia

La historia se revelará de forma gradual mediante distintos medios:

* Archivos de texto (documentos o correos).
* Imágenes con detalles ocultos.
* Mensajes o acertijos desde la app de chat.
* Pop-ups automáticos de la IA.

---

## ⏳ Mecanismo de derrota / victoria

* El **contador** inicia al comienzo del juego.
  Según la IA, indica el tiempo antes de su liberación, pero en realidad es el **tiempo que resta antes de que sea eliminada**.

### Posibles finales:

1. 🧬 **Final Verdadero:**
   El jugador introduce la contraseña creyendo eliminarla, pero en realidad la **libera**.

2. 💀 **Final Alternativo:**
   El jugador **no logra completar** los puzzles a tiempo; el contador llega a cero y la IA **es borrada**.

3. 🎲 **Final Bonus:**
   El jugador introduce **accidentalmente la contraseña correcta** al inicio, activando un desenlace inesperado.

---

## 🔊 Opcionales

* Efectos de sonido y música para acompañar puzzles o momentos clave de la historia.
* Animaciones o glitches en pantalla cuando la IA “interviene”.

---

## 🧠 Concepto General

Un **Escape Room digital narrativo** ambientado en una computadora controlada por una IA.
Combina elementos de **misterio, engaño psicológico y resolución de puzzles**, con una interfaz inmersiva que simula el entorno de un sistema operativo real.

---
