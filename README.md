
## Docker pipeline: {{dashed-namespace}}-docker-buildCI.yml

 - This pipeline is ran every time there is a **Pull Request** change targeting the `master` branch, and does the following steps:
	- **Build** Docker image
	- **Publish** Docker image to **Azure Container Registry]**
