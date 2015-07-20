%categorias
categoria('Adivina Quien',adivinaquien,1, 30).
categoria('Peleas',peleas,2, 20).
categoria('Sagas',sagas,3, 20).
categoria('Intruso',intruso,4, 20).
categoria('Hardcore',hardcore,5,20).

%notificaciones
notificacion(timeout,' El tiempo para responder esta pregunta ha acabado. ').
notificacion(correcta,' Respuesta correcta ').
notificacion(puntosganados,' Ha ganado ').
notificacion(incorrecta,' La respuesta es  incorrecta.').
notificacion(respuestacorrecta,'La respuesta correcta es: ').
notificacion(ganador1, ' Ha perdido! La maquina ha ganado esta partida. ').
notificacion(ganador2,' Ha ganado el juego, Felicidades! ').
notificacion(puntosperdidos,' La maquina ha respondido correctamente. ').
notificacion(empate,'Estan empatados!,Tienes la posibilidad de ganar,
	solo debes seleccionar una pregunta. Pero recuerda si respondes
	mal pierdes el juego.').

%preguntas categoria 1 (adivinaquien)
pregunta('Su padre fue el rey de los Saiyajins',adivinaquien,adivina1).
pregunta('Cumple el papel de co-protagonista en la serie manga Dragon Ball. Es una científica hija del Dr. Briefs.  Se convierte en la esposa de Vegeta y es uno de los personajes con mayor duración en toda la serie',adivinaquien,adivina2).
pregunta('Tiene 6 puntos en la frente y se rasura la cabeza. Entro en el templo de Orin. Es de raza humana y su ocupación es ser un guerrero Z. Quien es este personaje?',adivinaquien,adivina3).
pregunta('Es un humano-saiyajin, de color morado, ojos azules. Lleva un traje de pelea de color verde oscuro pulseras de color naranja y de niño demuestra ser muy arrogante. Tiene una hermana  y muchas veces demuestra su alta conocimiento científico característica que obtiene de su madre. Quien es',adivinaquien,adivina4).
pregunta('Tiene una melena peinada al estilo afro, un bigote largo que recorre la parte superior de sus labios, es arrogante, presumido, fanfarron, griton y manipulador y gano un torneo de artes marciales, quien es este personaje?',adivinaquien,adivina5).
pregunta('De cuantas estrellas es la esfera del dragon de songohan',adivinaquien,adivina6).

%preguntas categoria 2 (peleas).
pregunta('Por cual personaje Cell tuvo que absorber a miles de humanos
Para ganar la pelea',peleas,pelea1).
pregunta('Quien era el oponente mas débil en todas las peleas',peleas,pelea2).
pregunta('Quienes fueron derrotados en la pelea de los 3 super saiyajins',peleas,pelea3).
pregunta('Quien gano en la pelea de los 3 super saiyajins',peleas,pelea4).
pregunta('Cual es el antogonista principal de la película  Dragon Ball Z: La Batalla de los Dioses, y al parecer resulta ser el mayor gran reto para los Guerreros Z hasta ahora.',peleas,pelea5).

%preguntas categoria 3(sagas)
pregunta('Por cual personaje Cell tuvo que absorber a miles de humanos
Para ganar la pelea',sagas,saga1).
pregunta('En que saga  Piccolo  es mordido por los Spice Boys y lucha contra Gohan. El muerde a Krilin y le cuenta que está fingiendo ser poseído para obtener las botellas de Kami-Sama y Mr. Popo.',sagas,saga2).
pregunta('En que saga Vegeta alcanza un altísimo nivel de poder como SSJ2, superando en poder al resto de los Saiyajines, siendo de hecho el elegido por Baby para poseerlo por ser el cuerpo más poderoso que podía encontrar en el universo dado que Goku se había convertido en un niño de nuevo. ',sagas,saga3).
pregunta('Cual saga relataba las aventuras de Goku cuando era niño',sagas,saga4).
pregunta('En cual saga aparece majin boo',sagas,saga5).

%preguntas categoria 4(intruso).
pregunta('Cual de estos no es un humano/hibrido',intruso,intruso1).
pregunta('Cuantas veces murio krilin?',intruso,intruso2).
pregunta('Cual de estos no es majin',intruso,intruso3).
pregunta('Cual de estos no es sayajin',intruso,intruso4).
pregunta('Quien no fue soldado de freezer',intruso,intruso5).

%pregunta categoria 5(hardcore)
pregunta('¿Cuáles son las células que forman a Cell? ',hardcore,hardcore1).
pregunta('Cual es el segundo personaje de mayor duración en la serie?',hardcore,hardcore2).
pregunta('¿Quién es más fuerte, Gohan Saikyo no senshi (mystic) o Goku SSJ3? ',hardcore,hardcore3).
pregunta('¿Quién es más fuerte, Gohan Saikyo no senshi (mystic) o Gotenks SSJ3? ',hardcore,hardcore4).
pregunta('¿Quién es más fuerte, Gotenks SSJ3 o Goku SSJ3?',hardcore,hardcore5).

%respuestas categoria 1(adivinaquien)
respuesta(adivinaquien,adivina1,vegeta,200).
respuesta(adivinaquien,adivina2,bulma,400).
respuesta(adivinaquien,adivina3,krilin,600).
respuesta(adivinaquien,adivina4,trunks,800).
respuesta(adivinaquien,adivina5,'Mr. Satan',1000).
respuesta(adivinaquine,adivina6,4,1000).

%respuestas categoria 2(peleas)
respuesta(peleas,pelea1,piccolo,200).
respuesta(peleas,pelea2,'Mr. Satan',400).
respuesta(peleas,pelea3,'piccolo, trunks y vegeta',600).
respuesta(peleas,pelea4,goku,800).
respuesta(peleas,pelea5,bills,1000).

%respuesta categoria 3(sagas)
respuesta(sagas,saga1,vegetto,200).
respuesta(sagas,saga2,'Saga garlick jr.',400).
respuesta(sagas,saga3,'Dragon Ball GT',600).
respuesta(sagas,saga4,'Dragon Ball Z',800).
respuesta(sagas,saga5,'Dragon Ball Z',1000).

%respuesta categoria 4(intruso)
respuesta(intruso,intruso1,cell,200).
respuesta(intruso,intruso2,6,400).
respuesta(intruso,intruso3,'Todos son correctos',600).
respuesta(intruso,intruso4,piccolo,800).
respuesta(intruso,intruso5,krilin,1000).

%respuesta categoria 5(hardcore)
respuesta(hardcore,hardcore1,'Goku,Vegeta,Piccolo,Freezer y King Cold',200).
respuesta(hardcore,hardcore2,bulma,400).
respuesta(hardcore,hardcore3,gohan,600).
respuesta(hardcore,hardcore4,gohan,800).
respuesta(hardcore,hardcore5,gotenks,1000).

preguntas_por_categoria(Categoria,Id,Pregunta):-pregunta(Pregunta,Categoria,Id).
respuestas_por_categoria(Categoria,Id,Respuesta,Valor):-respuesta(Categoria,Id,Respuesta,Valor).

pierde(timeout,humano).
pierde(correcta,maquina).
pierde(incorrecta,humano).
pierde(respuestacorrecta,humano).
pierde(puntosperdidos,humano).
gana(ganador1,humano).
gana(ganador2,maquina).

jugandoconlamaquina(Estado,Turno):-
	(Estado ='timeout',
	 pierde(Estado,Turno));
	(Estado='incorrecta',
	 pierde(puntosperdidos,Turno)),
	!.

jugandoconlamaquina(Estado,Turno):-
	Estado ='correcta',
	pierde(correcta,Turno),!.

%Otro forma por si Void Winner No es funcional
ganador(Pjugador1,Pjugador2,Ganador):-
	Pjugador1<Pjugador2, Ganador is Pjugador2,!.

ganador(Pjugador1,Pjugador2,Ganador):-
	Pjugador1>Pjugador2, Ganador is Pjugador1,!.

ganador(Pjugador1,Pjugador2,Estado,Turno):-
	jugandoconlamaquina(Estado,Turno).






























