# Web Application

This is a web application built with ASP.NET MVC. This README includes instructions on how to deploy this application to Azure using an Azure Resource Manager (ARM) template and a GitHub Actions workflow.

## Prerequisites

- An Azure account
- A GitHub account
- The Azure CLI installed

## Deployment

### ARM Template

1. Clone this repository to your local machine.
git clone https://github.com/yourusername/yourrepository.git

2. Log in to your Azure account with the Azure CLI.
az login

3. Navigate to the directory containing the ARM template.
cd path/to/your/template

4. Deploy the ARM template. Replace `<resource-group>` with the name of your Azure resource group, and `<deployment-name>` with a name for the deployment.
az deployment group create --resource-group  --template-file template.json --name 

### GitHub Actions

1. Navigate to your repository on GitHub.

2. Click on the "Actions" tab.

3. Click on "New workflow".

4. Click on "set up a workflow yourself".

5. In the editor, paste the contents of the `.github/workflows/azure.yml` file from this repository.

6. Click on "Start commit" and commit the workflow to the `main` branch.

7. Whenever you push to the `main` branch, the GitHub Actions workflow will automatically deploy your application to Azure.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
