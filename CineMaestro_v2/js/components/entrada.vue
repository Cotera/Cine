
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

