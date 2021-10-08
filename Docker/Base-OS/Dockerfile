FROM ubuntu:20.04

#Install .NET Core SDK

RUN apt-get update &&\
apt-get install -y wget curl &&\
wget https://packages.microsoft.com/config/ubuntu/21.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb &&\
dpkg -i packages-microsoft-prod.deb &&\
rm packages-microsoft-prod.deb &&\
apt-get update; \
apt-get install -y apt-transport-https && \
apt-get update && \
apt-get install -y dotnet-sdk-5.0

#Install NodeJS

RUN cd ~ &&\
curl -fsSL https://deb.nodesource.com/setup_14.x -o nodesource_setup.sh &&\
bash ~/nodesource_setup.sh &&\
apt-get install -y nodejs

#Install Git

RUN apt-get update &&\
apt-get install -y git
