/* Função Validar */
const toggleButton = document.getElementsByClassName('toggle-button')[0]
const navbarLinks = document.getElementsByClassName('navbar-links')[0]

toggleButton.addEventListener('click', () => {
  navbarLinks.classList.toggle('active')
})

var form = document.getElementById("formulario");
 
if (form.addEventListener) {                   
    form.addEventListener("submit", validaCadastro);
} else if (form.attachEvent) {                  
    form.attachEvent("onsubmit", validaCadastro);
}
 
function validaCadastro(evt){
	var Name = document.getElementById("Nome");
  var Mail = document.getElementById("Email");
  var Assunt = document.getElementById("Assunto");
  var Mensagem = document.getElementById("Message");

	var filtro = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;
	var filtroo = /[0-9]/;
  
	var contErro = 0;

	/* Validação do campo nome */
	caixa_nome = document.querySelector('.msg-nome');
	if(Name.value == ""){
		caixa_nome.innerHTML = "O campo Nome deve ser preenchido!";
		caixa_nome.style.display = 'block';
        evt.preventDefault();
		contErro += 1;
	}else if(filtroo.test(Name.value)){
		caixa_nome.innerHTML = "O campo Nome não deve conter números!";
		caixa_nome.style.display = 'block';
        evt.preventDefault();
		contErro += 1;
	}else if(Nome.value.length < 2){
        caixa_nome.innerHTML = "O campo Nome deve ser maior que 02 digitos!";
		caixa_nome.style.display = 'block';
        evt.preventDefault();
		contErro += 1;	
	}else{
		caixa_nome.style.display = 'none';
	}

	/* Validação do campo email */
	caixa_mail = document.querySelector('.msg-mail');
	if(Mail.value == ""){
		caixa_mail.innerHTML = "O campo e-mail deve ser preenchido!";
		caixa_mail.style.display = 'block';
        evt.preventDefault();
		contErro += 1;

	}else if(filtro.test(Mail.value)){
		caixa_mail.style.display = 'none';
	}else{
		caixa_mail.innerHTML = "Formato do E-mail inválido";
		caixa_mail.style.display = 'block';
        evt.preventDefault();
		contErro += 1;
	}	

  /* Validação do campo Assunto */
	caixa_assunto = document.querySelector('.msg-assunto');
	if(Assunt.value == ""){
		caixa_assunto.innerHTML = "O campo Assunto deve ser preenchido!";
		caixa_assunto.style.display = 'block';
        evt.preventDefault();
		contErro += 1;

	}else if(Assunt.value.length < 2 ){
    caixa_assunto.innerHTML = "O campo Assunto deve ser maior que 02 digitos!";
		caixa_assunto.style.display = 'block';
        evt.preventDefault();
		contErro += 1;
	}else{
		caixa_assunto.style.display = 'none';
	}
 
	 /* Validação do campo Mensagem */
   caixa_mensagem = document.querySelector('.msg-mensagem');
   if(Mensagem.value == ""){
    caixa_mensagem.innerHTML = "O campo Mensagem deve ser preenchido!";
    caixa_mensagem.style.display = 'block';
         evt.preventDefault();
     contErro += 1;
  
   }else if(Mensagem.value.length < 2 ){
    caixa_mensagem.innerHTML = "O campo Mensagem deve ser maior que 02 digitos!";
    caixa_mensagem.style.display = 'block';
         evt.preventDefault();
     contErro += 1;
   }else{
    caixa_mensagem.style.display = 'none';
   }

}