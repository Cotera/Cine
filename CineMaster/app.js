import Vue from 'vue';
import Pelicula from './Pelicula';
import Entrada from './Entrada';

new Vue({
	el: '#app',
	components: {
		Pelicula,
		Entrada
	},
	template:'<Pelicula />'
	
	
});
