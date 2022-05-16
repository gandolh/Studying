const checkNume = (str)=>{
    let ans = str
    .match(
      /^[a-zA-Z]+$/
    );
    if(!ans)
        $('#nume').css('border','2px solid red');
    else
        $('#nume').css('border','none');
        return ans;
    }
const checkPrenume = (str)=>{
    let ans = str
    .match(
      /^[a-zA-Z]+$/
    );
    
    if(!ans)
        $('#prenume').css('border','2px solid red');
    else
        $('#prenume').css('border','none');
    return ans;
}
const checkEmail = (email) => {
    let ans = email
      
      .match(
        /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
      );
    
      if(!ans){
        $('#email').css('border','2px solid red');
        }else
      $('#email').css('border','none');
      return ans;
  };
  
const checkConfirmaEmail = (str)=>{
    
    let ans =  Boolean(str == $('#email').val() && checkEmail(str));
    if(!ans)
        $('#confirmaemail').css('border','2px solid red');
    else
      $('#confirmaemail').css('border','none');
    return ans;
}
const checkParola = (str)=>{
    let ans = str
    
    .match(
      /^[a-zA-Z]+$/
    );
    if(!ans){
        $('#parola').css('border','2px solid red');
    }else
    $('#parola').css('border','none');


    return ans;
}
const checkConfirmaParola = (str)=>{
    let ans = str == $('#parola').val() && checkParola(str);
    if(!ans)
        $('#confirmaparola').css('border','2px solid red');
        else
    $('#confirmaparola').css('border','none');
    return ans;
}
const checkAdresa = (str)=>{
    if(str=='')
        $('#adresa').css('border','2px solid red');
        else
    $('#adresa').css('border','none');
    return str!='';
}
const checkVarsta = (str)=>{
    let ans=str
    .match(
      /^[0-9]+$/
    )
    if(!ans)
        $('#varsta').css('border','2px solid red');
    else
        $('#varsta').css('border','none');
    return ans;
}

const validateForm=()=>{
    let valid1= checkNume($('#nume').val());
    let valid2= checkPrenume($('#prenume').val());
    let valid3= checkEmail($('#email').val());
    let valid4= checkConfirmaEmail($('#confirmaemail').val());
    let valid5= checkParola($('#parola').val());
    let valid6= checkConfirmaParola($('#confirmaparola').val());
    let valid7= checkAdresa($('#adresa').val());
    let valid8= checkVarsta($('#varsta').val());
    return Boolean(valid1 && valid2 && valid3 && valid4 && valid5 && valid6
    && valid7 && valid8);
}