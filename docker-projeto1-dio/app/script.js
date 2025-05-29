// Este código adiciona um evento de clique ao botão com ID 'btn-alerta'
// Quando o botão é clicado, exibe um alerta confirmando que a aplicação está funcionando no Docker

document.getElementById('btn-alerta').addEventListener('click', () => {
    alert('Funcionou! A aplicação está rodando corretamente no container Docker!');
});