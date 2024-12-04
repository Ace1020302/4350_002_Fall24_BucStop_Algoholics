#!/bin/bash

#################################################################################
# This script is used to automatically call all docker commands for redeployment. 
# You will be prompted to enter in your DOCKER username and the associated DOCKER
# image that your build of BucStop exists in.
#################################################################################

# User prompts for docker username and image name
read -p "Enter your docker username: " $username
read -p "Enter your Docker image name: " $image

# Change directory back to the parent directory of BucStop
cd ..

# Perform the redeployment scripts of building and pushing the updated image
sudo docker build -f BucStop/Dockerfile -t $username/$image .
sudo docker push $username/$image 
