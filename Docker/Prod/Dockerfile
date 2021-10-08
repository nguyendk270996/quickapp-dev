FROM 10.7.7.1:8123/quickapp-ubuntu

ARG CONF
ARG decrypt_key
ARG TOKEN

RUN git clone http://$TOKEN@10.7.7.2/quickapp-prod/quickapp.git /App &&\
cd /App/QuickApp &&\
dotnet restore &&\
cd ClientApp &&\
npm install

RUN cd /App/QuickApp/ &&\
gpg --output appsettings.Production.json --batch --yes --passphrase $decrypt_key --decrypt appsettings.Production.json.gpg &&\
dotnet publish -c $CONF

EXPOSE 5069
EXPOSE 5070

