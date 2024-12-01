# Biblografia
## Paginas Web:

__Vikipèdia, Metodòlogia Àgil__

23/11/2024

https://ca.wikipedia.org/wiki/Metodologia_àgil

__Openacces, Metodòlogies àgils__

23/11/2024

https://openaccess.uoc.edu/bitstream/10609/141366/1/Tecniques%20avanc¿ades%20de%20l%27enginyeria%20de%20programari_Modul1_Metodologies%20agils.pdf

__Linkedin, ¿Cómo se usan los dobles de prueba, como simulacros y esbozos, en el desarrollo basado en pruebas?__

24/11/2024

https://es.linkedin.com/advice/3/how-do-you-use-test-doubles-mocks-stubs?lang=es#:~:text=Los%20dobles%20de%20prueba%20son,probando%20del%20resto%20del%20sistema.

__DevExpert,  ¿Qué son los dobles de test?__

24/11/2024

https://devexpert.io/dobles-test/

## IAS

### ChatGPT

__Pregunta: ¿Qué son las metodologías ágiles y para qué sirven en el ámbito de la programación?__

__Respuesta:__

Las metodologías ágiles son un conjunto de enfoques y prácticas para la gestión de proyectos que se centran en la colaboración, la adaptabilidad y la entrega rápida de valor. Estas metodologías son especialmente utilizadas en el ámbito de la programación y desarrollo de software, aunque también se han extendido a otros campos.

__¿Qué son las metodologías ágiles?__

Las metodologías ágiles son un marco de trabajo que se basa en los principios establecidos en el Manifiesto Ágil (2001). Este manifiesto destaca cuatro valores principales:

- Individuos e interacciones sobre procesos y herramientas.
- Software funcionando sobre documentación extensiva.
- Colaboración con el cliente sobre la negociación de contratos.
- Respuesta ante el cambio sobre seguir un plan rígido.
- Se caracterizan por ser iterativas, incrementales y adaptativas, lo que - significa que el desarrollo se divide en ciclos cortos llamados sprints (en Scrum) o iteraciones, y el equipo puede ajustar su rumbo en función del feedback.

__¿Para qué sirven en programación?__

En el ámbito de la programación, las metodologías ágiles son herramientas clave para gestionar proyectos de software de forma eficiente y flexible. Algunos de los beneficios principales incluyen:

1. Facilitar la colaboración entre equipos y clientes
Promueven una comunicación constante y efectiva entre desarrolladores, partes interesadas y clientes.
Permiten recoger feedback frecuente, lo que asegura que el producto final esté alineado con las necesidades reales del cliente.

2. Adaptarse a cambios en los requisitos
En lugar de seguir un plan rígido, las metodologías ágiles permiten realizar ajustes en cualquier momento del proyecto.
Esto es útil en entornos donde los requisitos pueden evolucionar rápidamente.

3. Entregar valor rápidamente
Al dividir el desarrollo en entregas incrementales, el cliente puede recibir un producto funcional en etapas tempranas y utilizarlo antes de que el proyecto completo esté terminado.

4. Mejorar la calidad del software
Las revisiones constantes y las pruebas integradas en el proceso ayudan a detectar errores más rápido y mantener altos estándares de calidad.

5. Fomentar la motivación del equipo
Los equipos ágiles suelen ser autogestionados, lo que da más autonomía y fomenta la creatividad.

__Metodologías ágiles populares en programación__

Existen varias metodologías que se consideran ágiles, entre ellas:

__Scrum:__ Organización de proyectos en sprints (generalmente de 2-4 semanas) y reuniones diarias (daily stand-ups).

__Kanban:__ Visualización del flujo de trabajo en un tablero para identificar cuellos de botella y mejorar la eficiencia.

__Extreme Programming (XP):__ Enfoque en la mejora continua y buenas prácticas de programación, como el desarrollo basado en pruebas (TDD) y la programación en pares.

__Lean Development:__ Inspirada en la manufactura Lean, busca maximizar el valor y minimizar el desperdicio.

__Conclusión__

Las metodologías ágiles son fundamentales en programación porque permiten gestionar proyectos de manera más flexible y eficiente, mejorando la calidad del software y asegurando que cumpla con las expectativas del cliente en un entorno cambiante. Su éxito radica en su capacidad de adaptarse, fomentar la colaboración y centrarse en la entrega continua de valor.

### ChatGpt

__Pregunta: ¿Qué son los dobles de prueba y que tipos hay?__

__Respuesta:__

Los dobles de prueba son objetos o componentes simulados que se utilizan en el ámbito de las pruebas de software para sustituir dependencias reales. Estos permiten aislar y controlar el entorno de pruebas, ayudando a evaluar el comportamiento de una unidad de código (por ejemplo, una función, clase o módulo) sin depender de componentes externos como bases de datos, APIs externas, o sistemas complejos.

__¿Por qué usar dobles de prueba?__

- Aislar la unidad bajo prueba: Permiten probar una unidad de código sin depender de factores externos que podrían introducir errores no relacionados con la unidad.

- Controlar el entorno de pruebas: Se pueden predefinir respuestas esperadas para asegurarse de que la prueba sea predecible y repetible.

- Mejorar la velocidad: Evitan la necesidad de interactuar con componentes reales que podrían ser lentos o costosos (como bases de datos o servicios de red).

- Simular casos difíciles de reproducir: Facilitan la simulación de fallos o comportamientos específicos en dependencias externas.

__Tipos de dobles de prueba__

Martin Fowler, uno de los expertos en diseño y pruebas de software, define cinco tipos principales de dobles de prueba:

1. Dummies (Objetos de Relleno)
Propósito: Se usan cuando se necesita proporcionar un objeto porque la interfaz lo exige, pero no se utiliza activamente en la prueba.
Ejemplo: Un constructor de clase que requiere un parámetro no relevante para la prueba.

Características: Suelen ser instancias vacías o mínimamente implementadas.

2. Fakes (Simulaciones Simplificadas)
Propósito: Son implementaciones ligeras de un componente que funcionan de forma simplificada en lugar de la dependencia real.
Ejemplo: Una base de datos en memoria que sustituye a una base de datos real.

Características: Son funcionales, pero no están diseñados para entornos de producción.

3. Stubs (Respuestas Predefinidas)
Propósito: Devuelven valores predefinidos cuando se les llama, permitiendo probar cómo una unidad interactúa con datos específicos.
Ejemplo: Un stub que siempre devuelve una lista de usuarios simulados cuando se consulta.

Características: Simulan respuestas de métodos o funciones.

4. Mocks (Expectativas Verificables)
Propósito: Permiten verificar si un método o función fue llamado con los argumentos esperados y en el momento correcto.
Ejemplo: Un mock que verifica que un método de envío de correo fue llamado después de crear un usuario.

Características: Incluyen la capacidad de establecer expectativas y validarlas durante las pruebas.

5. Spies (Espías)
Propósito: Parecidos a los mocks, pero también registran y reportan detalles de las interacciones sin necesidad de establecer expectativas previas.
Ejemplo: Un spy que registra cuántas veces se llamó a un método y con qué parámetros.

Características: Se utilizan para análisis pasivo del comportamiento del código.

__Resumen de diferencias__
| Tipo | Propósito Principal | Interacción | Ejemplo Típico |
| ----- | ----- | ----- | ----- |
| Dummy | Satisfacer requisitos formales del código | No se utiliza activamente | Un objeto nulo pasado a un constructor. |
| Fake | Simulación funcional simplificada | Actúa como una versión simplificada | Una base de datos en memoria. |
| Stub | Proveer respuestas predefinidas | Responde valores específicos | Método que siempre devuelve "OK". |
| Mock | Verificar interacciones con expectativas previas | Valida llamadas y argumentos | Verificar si un método fue llamado. |
| Spy | Registrar interacciones para análisis posterior | Observa sin expectativas previas | Contar cuántas veces se invocó algo. |

__¿Cuándo usar cada tipo?__

Usa dummies para cumplir con dependencias mínimas.

Usa fakes cuando necesitas funcionalidad simplificada pero operativa.

Usa stubs para pruebas centradas en respuestas específicas.

Usa mocks cuando necesitas validar interacciones precisas.

Usa spies para analizar comportamiento sin establecer expectativas rígidas.
El uso correcto de dobles de prueba facilita el desarrollo de pruebas más efectivas, controladas y fiables.

### ChatGpt

__Pregunta: que es CI/CD?__

__Respuesta:__

CI/CD es un conjunto de prácticas y herramientas que se utilizan en el desarrollo de software para automatizar y acelerar la entrega de aplicaciones. El término incluye dos conceptos principales: Integración Continua (CI) y Entrega/Despliegue Continuo (CD).

__¿Qué es CI/CD?__

Integración Continua (CI - Continuous Integration):

Se refiere a la práctica de integrar frecuentemente el código de todos los desarrolladores en un repositorio compartido.

Cada integración se verifica automáticamente mediante la ejecución de pruebas unitarias, análisis de calidad del código y compilaciones.

Objetivo: Detectar errores en una etapa temprana y asegurarse de que el código de cada desarrollador sea compatible con el del resto.

Entrega/Despliegue Continuo (CD - Continuous Delivery/Continuous Deployment):
Entrega Continua (Continuous Delivery):

Automatiza la preparación del código para que esté listo para ser desplegado en producción en cualquier momento.

La decisión de desplegar a producción es manual, pero todo lo demás (pruebas, empaquetado) está automatizado.

Despliegue Continuo (Continuous Deployment):
Extiende la entrega continua al desplegar automáticamente el código en producción una vez que pasa las pruebas.

No hay intervención manual; el código aprobado por las pruebas llega directamente al entorno de producción.

__Beneficios de CI/CD__

- Despliegues más rápidos y frecuentes:
Permite entregar nuevas funciones y correcciones a los usuarios con mayor rapidez.

- Mejor calidad del software:
Al automatizar las pruebas, se detectan errores antes de que lleguen a producción.

- Feedback más temprano:
Los problemas en el código son detectados inmediatamente después de un commit, reduciendo el costo de corregirlos.

- Colaboración fluida:
Los equipos de desarrollo y operaciones trabajan juntos bajo la filosofía DevOps.

- Menor riesgo:
Los cambios son pequeños y frecuentes, lo que hace más fácil revertir errores.

__Componentes clave de CI/CD__

- Repositorio de código fuente (Version Control):
Herramientas como Git (en plataformas como GitHub, GitLab o Bitbucket) donde los desarrolladores colaboran y versionan el código.

- Integración automática:
Se activan pipelines (flujos de trabajo automatizados) tras cada cambio (commit o merge) para compilar, probar y verificar el código.

- Automatización de pruebas:
Incluye pruebas unitarias, funcionales, de integración y de rendimiento.

- Gestión de infraestructura:
Herramientas como Docker y Kubernetes para empaquetar y desplegar aplicaciones de manera uniforme en diferentes entornos.

- Monitoreo y retroalimentación:
Se utilizan herramientas como Prometheus, Grafana o New Relic para monitorear el rendimiento del software en producción y garantizar su estabilidad.

__Herramientas populares para CI/CD__

- Jenkins: Plataforma de automatización extensible y de código abierto.

- GitLab CI/CD: Sistema integrado en GitLab que permite gestionar pipelines.

- CircleCI: Servicio que facilita la configuración de pipelines CI/CD.

- Travis CI: Herramienta basada en la nube para proyectos en GitHub.

- GitHub Actions: Integración de workflows en GitHub.

- Azure DevOps, AWS CodePipeline, Google Cloud Build: Opciones de CI/CD en la nube.

__Flujo típico de CI/CD__

1. CI (Integración Continua):  
   * Un desarrollador hace un cambio y realiza un commit en el repositorio.  
   * Un pipeline se activa automáticamente:  
     * Se compila el código.  
     * Se ejecutan pruebas unitarias.  
     * Se generan reportes de calidad del código.  
   * Si todo es exitoso, el código se integra en la rama principal.  
2. CD (Entrega/Despliegue Continuo):  
   * El pipeline continúa:  
     * Se realizan pruebas de integración y aceptación.  
     * Se empaqueta la aplicación (por ejemplo, en contenedores Docker).  
   * Si se utiliza Entrega Continua, el equipo decide si despliega manualmente.  
   * Si se utiliza Despliegue Continuo, el pipeline finaliza desplegando automáticamente el código en producción.

__CI/CD y DevOps__

CI/CD es un pilar clave dentro de la cultura DevOps, ya que fomenta:

- Colaboración entre desarrollo y operaciones.

- Automatización para eliminar procesos manuales y repetitivos.

- Entrega de valor continua a los usuarios finales.

En resumen, CI/CD transforma la forma en que los equipos de desarrollo y operaciones trabajan juntos, acelerando el desarrollo de software mientras mantienen alta calidad y estabilidad.
