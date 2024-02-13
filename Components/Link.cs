public class Link
{
    public string? Type { get; set; }
    public string? Title { get; set; }
    public string? Url { get; set; }
    public string? Category { get; set; }
    public string? Product { get; set; }

    public string? Image
    { 
        get { return GetImage(Product);}
        // set; 
    }

    private string GetImage(string product)
    {
        string result = "link-45deg.svg";

        if (product != null)
        {
            switch (product)
            {
                case "Functions":
                    result = "./images/10029-icon-service-Function-Apps.svg";
                    break;
                case "Static web apps":
                    result = "./images/01007-icon-service-Static-Apps.svg";
                    break;
                case "App service":
                    result = "./images/10035-icon-service-App-Services.svg";
                    break;
                case "Kubernetes service":
                    result = "./images/10023-icon-service-Kubernetes-Services.svg";
                    break;
                case "Container apps":
                    result = "./images/02884-icon-service-Worker-Container-App.svg";
                    break;
                case "Container instances":
                    result = "./images/10104-icon-service-Container-Instances.svg";
                    break;
                case "Language":
                    result = "./images/02876-icon-service-Language.svg";
                    break;
                case "Custom vision":
                    result = "./images/00793-icon-service-Custom-Vision.svg";
                    break;
                case "Computer vision":
                    result = "./images/00792-icon-service-Computer-Vision.svg";
                    break;
                case "Python":
                    result = "./images/python.jpg";
                    break;
                case "OpenAI":
                    result = "./images/openai.jpg";
                    break;
                default:
                    result = "link-45deg.svg";
                    break;
            }
        }
        return result;
    }
}

