# Usa a imagem com a versão específica e mais leve e oficial do Apache
FROM httpd:2.4.57-alpine

# Copia os arquivos da aplicação para o container
COPY ./app/ /usr/local/apache2/htdocs/

# Expõe a porta 80 (porta padrão do Apache)
EXPOSE 80