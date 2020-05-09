
## Build pipeline: {{dashed-namespace}}-svc-buildCI.yml

 - This pipeline is ran every time there is a **Pull Request** change targeting the `master` branch, and does the following steps:
	- Restore **Nuget** dependencies
	- **Build** the solution
	- Run **Unit Test**
	- Publish the **Coverage Report** to **Azure DevOps** using **Cobertura**
	- Publish the **Solution Artifact** to **Azure DevOps**
