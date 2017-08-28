


Vue.component( 'pelis-header', {
	template: `
		<div class="header h-peli">
			<h1>
			Pel&iacute;culas
			</h1>
		</div>
	`
});

Vue.component( 'pelis-content', {
	template: `
		<div class="container">
			<div class="row t-header">
				<div class="col-md-2"> ID </div>
				
				<div class="col-md-2"> TITULO </div>
				
				<div class="col-md-2"> DIRECTOR </div>
				
				<div class="col-md-2"> A&Ntilde;O </div>
				
				<div class="col-md-2"> SALA </div>
			</div>
			
			<div class="row t-body">
				<div class="col-md-2"> </div>
				
				<div class="col-md-2"> </div>
				
				<div class="col-md-2"> </div>
				
				<div class="col-md-2"> </div>
			</div>
		</div>
	`
});



Vue.component( 'entradas-header', {
	template: `
		<div class="header h-entrada">
			<h1>
			Entradas
			</h1>
		</div>
	`
});

Vue.component( 'entradas-content', {
	template: `
		<div class="container">
			<div class="row t-header">
				<div class="col-md-3"> ID </div>
				
				<div class="col-md-3"> FILA </div>
				
				<div class="col-md-3"> BUTACA </div>
				
				<div class="col-md-3"> TITULAR </div>
			</div>
			
			<div class="row t-body">
				<div class="col-md-3"> </div>
				
				<div class="col-md-3"> </div>
				
				<div class="col-md-3"> </div>
			
				<div class="col-md-3"> </div>
			</div>
		</div>
	`
});



Vue.component( 'peli', {
	/*data: {
		titulo: 'Pel&iacute;culas',
		Peliculas:[{
			Id: 1,
			Titulo:"La Peli",
			Director:"Pepe",
			Anio:2017,
			Sala:12
		},{
			Id: 2,
			Titulo:"Filmando",
			Director:"Papuchi",
			Anio:2012,
			Sala:4
		}]
	},*/
	components:{
		'pelis-header': pelis-header,
		'pelis-content': pelis-content
	},
	template: `
		<pelis-header></pelis-header>
		<pelis-content></pelis-content>
	`
});

Vue.component( 'entrada', {
	/*data: {
		titulo: 'Entradas',
		Entradas:[{
			Id: 11,
			Fila: 3,
			Butaca: 9,
			Titular: "Maribel"
		},{
			Id: 21,
			Fila: 3,
			Butaca: 9,
			Titular: "Maribel"
		}]
	},*/
	components:{
		'entradas-header': entradas-header,
		'entradas-content': entradas-content
	},
	template: `
		<entradas-header></entradas-header>
		<entradas-content></entradas-content>
	`
};

const app = new Vue({
	el: '#app',
	components: {
		'entrada': entrada,
		'peli': peli
	}
	
	
});
