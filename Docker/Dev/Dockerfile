ARG REPO_PATH
ARG IMAGE_NAME
FROM $REPO_PATH/$IMAGE_NAME

ARG CONF
ARG decrypt_key
ARG TOKEN

RUN git clone http://$TOKEN@10.7.7.2/quickapp-dev/quickapp.git /App &&\
cd /App/QuickApp &&\
dotnet restore &&\
cd ClientApp &&\
npm install

RUN cd /App/QuickApp/ &&\
gpg --output appsettings.Devtest.json --batch --yes --passphrase $decrypt_key --decrypt appsettings.Development.json.gpg &&\
dotnet publish -c $CONF

WORKDIR /App/QuickApp

EXPOSE 5000
EXPOSE 5001
