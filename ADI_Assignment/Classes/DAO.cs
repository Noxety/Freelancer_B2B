using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Freelancer_client.Classes
{
    public class DAO
    {
        public static string connectionString = "server=localhost;database=adi_assignment;UID=root;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public bool InsertFreelancer(Freelancer freelancer)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                string hashedpassword = freelancer.HashPassword(freelancer.Password);
                connection.Open();
                string query = "insert into user (username, password, email, phone) values (@name, @password, @email, @phone)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", freelancer.Username);
                cmd.Parameters.AddWithValue("@password", hashedpassword);
                cmd.Parameters.AddWithValue("@email", freelancer.Email);
                cmd.Parameters.AddWithValue("@phone", freelancer.Phone);
                cmd.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string quer = "select id from user where username=@name";
                MySqlCommand cm = new MySqlCommand(quer, connection);
                cm.Parameters.AddWithValue("@name", freelancer.Username);
                MySqlDataReader res = cm.ExecuteReader();
                res.Read();
                int freelancerID = res.GetInt32("id");
                connection.Close();
                connection.Open();
                string query2 = "insert into freelancer (skills, expertise, porfolio,userid) values (@skills, @expertise, @portfolio, @userid)";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                cmd2.Parameters.AddWithValue("@skills", freelancer.Skills);
                cmd2.Parameters.AddWithValue("@expertise", freelancer.Expertise);
                cmd2.Parameters.AddWithValue("@portfolio", freelancer.Porfolio);
                cmd2.Parameters.AddWithValue("@userid", freelancerID);
                cmd2.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return false;
            }
        }

        public bool InsertClient(Client client)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                string hashedpassword = client.HashPassword(client.Password);
                connection.Open();
                string query = "insert into user (username, password, email, phone) values (@name, @password, @email, @phone)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", client.Username);
                cmd.Parameters.AddWithValue("@password", hashedpassword);
                cmd.Parameters.AddWithValue("@email", client.Email);
                cmd.Parameters.AddWithValue("@phone", client.Phone);
                cmd.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string quer = "select id from user where username=@name";
                MySqlCommand cm = new MySqlCommand(quer, connection);
                cm.Parameters.AddWithValue("@name", client.Username);
                MySqlDataReader res = cm.ExecuteReader();
                res.Read();
                int clientID = res.GetInt32("id");
                connection.Close();
                connection.Open();
                string query2 = "insert into client (companyName, companyAddress, companyPhone, companyEmail, companyWebsite, companyDescription, userid) values (@company_name, @company_address, @company_phone, @company_email, @company_website, @company_description, @userid)";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                cmd2.Parameters.AddWithValue("@company_name", client.CompanyName);
                cmd2.Parameters.AddWithValue("@company_address", client.CompanyAddress);
                cmd2.Parameters.AddWithValue("@company_phone", client.CompanyPhone);
                cmd2.Parameters.AddWithValue("@company_email", client.CompanyEmail);
                cmd2.Parameters.AddWithValue("@company_website", client.CompanyWebsite);
                cmd2.Parameters.AddWithValue("@company_description", client.CompanyDescription);

                cmd2.Parameters.AddWithValue("@userid", clientID);
                cmd2.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return false;
            }
        }

        public Freelancer FindFreelancer(string username, string password)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                Freelancer freelancer = new Freelancer();
                string hashedpass = freelancer.HashPassword(password);
                connection.Open();
                string query = "select * from user where username=@name and password=@password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@password", hashedpass);
                MySqlDataReader res = cmd.ExecuteReader();
                if (res.Read())
                {
                    int id = res.GetInt32("id");
                    string username1 = res.GetString("username");
                    string password1 = res.GetString("password");
                    string email = res.GetString("email");
                    string phone = res.GetString("phone");
                    connection.Close();

                    connection.Open();
                    string query2 = "select * from freelancer where userid=@id";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                    cmd2.Parameters.AddWithValue("@id", id);
                    MySqlDataReader res2 = cmd2.ExecuteReader();
                    if (res2.Read())
                    {
                        Freelancer freelancer1 = new Freelancer();
                        freelancer1.FreelancerId = res2.GetInt32("id");
                        freelancer1.Id = id;
                        freelancer1.Username = username1;
                        freelancer1.Password = password1;
                        freelancer1.Email = email;
                        freelancer1.Phone = phone;
                        freelancer1.Skills = res2.GetString("skills");
                        freelancer1.Expertise = res2.GetString("expertise");
                        freelancer1.Porfolio = res2.GetString("porfolio");
                        return freelancer1;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public List<Freelancer> GetAllFreelancer()
        {
            List<Freelancer> freelancers = new List<Freelancer>();
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "select * from freelancer";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    Freelancer freelancer = new Freelancer();
                    freelancer.FreelancerId = res.GetInt32("id");
                    freelancer.Skills = res.GetString("skills");
                    freelancer.Expertise = res.GetString("expertise");
                    freelancer.Porfolio = res.GetString("porfolio");
                    freelancer.Id = res.GetInt32("userid");
                    freelancers.Add(freelancer);
                }
                connection.Close();

                string query1 = "select * from user where id=@id";
                foreach (Freelancer f in freelancers)
                {
                    connection.Open();
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                    cmd1.Parameters.AddWithValue("@id", f.Id);
                    MySqlDataReader res1 = cmd1.ExecuteReader();
                    if (res1.Read())
                    {
                        f.Username = res1.GetString("username");
                        f.Email = res1.GetString("email");
                        f.Phone = res1.GetString("phone");
                    }
                    connection.Close();
                }
                return freelancers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public Client FindClient(string username, string password)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                Client client1 = new Client();
                string hashedpass = client1.HashPassword(password);

                connection.Open();
                string query = "select * from user where username=@name and password=@password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@password", hashedpass);
                MySqlDataReader res = cmd.ExecuteReader();
                if (res.Read())
                {
                    int id = res.GetInt32("id");
                    string username1 = res.GetString("username");
                    string password1 = res.GetString("password");
                    string email = res.GetString("email");
                    string phone = res.GetString("phone");
                    connection.Close();

                    connection.Open();
                    string query2 = "select * from client where userid=@id";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                    cmd2.Parameters.AddWithValue("@id", id);
                    MySqlDataReader res2 = cmd2.ExecuteReader();
                    if (res2.Read())
                    {
                        Client client = new Client();
                        client.ClientId = res2.GetInt32("id");
                        client.Id = id;
                        client.Username = username1;
                        client.Password = password1;
                        client.Email = email;
                        client.Phone = phone;
                        client.CompanyName = res2.GetString("companyName");
                        client.CompanyAddress = res2.GetString("companyAddress");
                        client.CompanyPhone = res2.GetString("companyPhone");
                        client.CompanyEmail = res2.GetString("companyEmail");
                        client.CompanyWebsite = res2.GetString("companyWebsite");
                        client.CompanyDescription = res2.GetString("companyDescription");
                        return client;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public bool UpdateClient(Client client)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query2 = "update client set companyName=@company_name, companyAddress=@company_address, companyPhone=@company_phone, companyEmail=@company_email, companyWebsite=@company_website, companyDescription=@company_description where id=@id";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                cmd2.Parameters.AddWithValue("@company_name", client.CompanyName);
                cmd2.Parameters.AddWithValue("@company_address", client.CompanyAddress);
                cmd2.Parameters.AddWithValue("@company_phone", client.CompanyPhone);
                cmd2.Parameters.AddWithValue("@company_email", client.CompanyEmail);
                cmd2.Parameters.AddWithValue("@company_website", client.CompanyWebsite);
                cmd2.Parameters.AddWithValue("@company_description", client.CompanyDescription);

                cmd2.Parameters.AddWithValue("@id", client.ClientId);
                cmd2.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return false;
            }
        }

        public bool UpdateFreelancer(Freelancer freelancer)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "update user set username=@name, email=@email, phone=@phone where id=@id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", freelancer.Username);
                cmd.Parameters.AddWithValue("@email", freelancer.Email);
                cmd.Parameters.AddWithValue("@phone", freelancer.Phone);
                cmd.Parameters.AddWithValue("@id", freelancer.Id);
                cmd.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string query2 = "update freelancer set skills=@skills, expertise=@expertise, porfolio=@portfolio where id=@id";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                cmd2.Parameters.AddWithValue("@skills", freelancer.Skills);
                cmd2.Parameters.AddWithValue("@expertise", freelancer.Expertise);
                cmd2.Parameters.AddWithValue("@portfolio", freelancer.Porfolio);
                cmd2.Parameters.AddWithValue("@id", freelancer.FreelancerId);
                cmd2.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return false;
            }
        }

        public bool CreateProject(Project project, int cid)
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertProjectQuery = @"
                INSERT INTO project 
                (projectName, projectDescription, projectSkills, projectBudget, projectDuration, projectStatus, projectDeadline, projectCompletedDate, projectCreatedDate) 
                VALUES 
                (@projectName, @projectDescription, @projectSkills, @projectBudget, @projectDuration, @projectStatus, @projectDeadline, @projectCompletedDate, @projectCreatedDate);
                SELECT LAST_INSERT_ID();";

                    int projectID;
                    using (MySqlCommand cmd = new MySqlCommand(insertProjectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@projectName", project.ProjectName);
                        cmd.Parameters.AddWithValue("@projectDescription", project.ProjectDescription);
                        cmd.Parameters.AddWithValue("@projectSkills", project.ProjectSkills);
                        cmd.Parameters.AddWithValue("@projectBudget", project.ProjectBudget);
                        cmd.Parameters.AddWithValue("@projectDuration", project.ProjectDuration);
                        cmd.Parameters.AddWithValue("@projectStatus", project.ProjectStatus);
                        cmd.Parameters.AddWithValue("@projectDeadline", project.ProjectDeadline);
                        cmd.Parameters.AddWithValue("@projectCompletedDate", project.ProjectCompletedDate);
                        cmd.Parameters.AddWithValue("@projectCreatedDate", project.ProjectCreatedDate);


                        projectID = Convert.ToInt32(cmd.ExecuteScalar());
                    }


                    string insertClientProjectQuery = @" INSERT INTO adi_assignment.client_project (client_id, project_id) VALUES (@client_id, @project_id);";

                    using (MySqlCommand cmd = new MySqlCommand(insertClientProjectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@client_id", cid);
                        cmd.Parameters.AddWithValue("@project_id", projectID);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public List<Project> Project_client(int cid)
        {
            List<Project> projects = new List<Project>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // First query to get project IDs
                    string query = "SELECT project_id FROM adi_assignment.client_project WHERE client_id = @cid";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cid", cid);
                        using (MySqlDataReader res = cmd.ExecuteReader())
                        {
                            List<int> projectIds = new List<int>();

                            while (res.Read())
                            {
                                projectIds.Add(res.GetInt32("project_id"));
                            }

                            res.Close();


                            foreach (int pid in projectIds)
                            {
                                string query1 = "SELECT * FROM project WHERE id = @pid";
                                using (MySqlCommand cmd1 = new MySqlCommand(query1, connection))
                                {
                                    cmd1.Parameters.AddWithValue("@pid", pid);
                                    using (MySqlDataReader res1 = cmd1.ExecuteReader())
                                    {
                                        if (res1.Read())
                                        {
                                            Project project = new Project
                                            {
                                                ProjectId = res1.GetInt32("id"),
                                                ProjectName = res1.GetString("projectName"),
                                                ProjectDescription = res1.GetString("projectDescription"),
                                                ProjectSkills = res1.GetString("projectSkills"),
                                                ProjectBudget = res1.GetDouble("projectBudget"),
                                                ProjectDuration = res1.GetString("projectDuration"),
                                                ProjectStatus = res1.GetString("projectStatus"),
                                                ProjectDeadline = res1.GetString("projectDeadline"),
                                                ProjectCompletedDate = res1.GetDateTime("projectCompletedDate"),
                                                ProjectCreatedDate = res1.GetDateTime("projectCreatedDate")
                                            };
                                            projects.Add(project);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return projects;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public List<Project> Project_Freelancer(int fid)
        {
            List<Project> projects = new List<Project>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // First query to get project IDs
                    string query = "SELECT project_id FROM adi_assignment.freelancer_project WHERE freelancer_id = @fid";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@fid", fid);
                        using (MySqlDataReader res = cmd.ExecuteReader())
                        {
                            List<int> projectIds = new List<int>();
                            while (res.Read())
                            {
                                projectIds.Add(res.GetInt32("project_id"));
                            }
                            res.Close();
                            foreach (int pid in projectIds)
                            {
                                string query1 = "SELECT * FROM project WHERE id = @pid";
                                using (MySqlCommand cmd1 = new MySqlCommand(query1, connection))
                                {
                                    cmd1.Parameters.AddWithValue("@pid", pid);
                                    using (MySqlDataReader res1 = cmd1.ExecuteReader())
                                    {
                                        if (res1.Read())
                                        {
                                            Project project = new Project
                                            {
                                                ProjectId = res1.GetInt32("id"),
                                                ProjectName = res1.GetString("projectName"),
                                                ProjectDescription = res1.GetString("projectDescription"),
                                                ProjectSkills = res1.GetString("projectSkills"),
                                                ProjectBudget = res1.GetDouble("projectBudget"),
                                                ProjectDuration = res1.GetString("projectDuration"),
                                                ProjectStatus = res1.GetString("projectStatus"),
                                                ProjectDeadline = res1.GetString("projectDeadline"),
                                                ProjectCompletedDate = res1.GetDateTime("projectCompletedDate"),
                                                ProjectCreatedDate = res1.GetDateTime("projectCreatedDate")
                                            };
                                            projects.Add(project);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    return projects;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public List<Project> ProjectsByExpertise(string expertise)
        {
            List<Project> projects = new List<Project>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM project WHERE projectSkills LIKE @expertise";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@expertise", "%" + expertise + "%");
                        using (MySqlDataReader res = cmd.ExecuteReader())
                        {
                            while (res.Read())
                            {
                                Project project = new Project
                                {
                                    ProjectId = res.GetInt32("id"),
                                    ProjectName = res.GetString("projectName"),
                                    ProjectDescription = res.GetString("projectDescription"),
                                    ProjectSkills = res.GetString("projectSkills"),
                                    ProjectBudget = res.GetDouble("projectBudget"),
                                    ProjectDuration = res.GetString("projectDuration"),
                                    ProjectStatus = res.GetString("projectStatus"),
                                    ProjectDeadline = res.GetString("projectDeadline"),
                                    ProjectCompletedDate = res.GetDateTime("projectCompletedDate"),
                                    ProjectCreatedDate = res.GetDateTime("projectCreatedDate")
                                };
                                projects.Add(project);
                            }
                        }
                    }
                    string query1 = "SELECT * FROM project WHERE projectSkills NOT LIKE @expertise";
                    using (MySqlCommand cmd1 = new MySqlCommand(query1, connection))
                    {
                        cmd1.Parameters.AddWithValue("@expertise", "%" + expertise + "%");
                        using (MySqlDataReader res1 = cmd1.ExecuteReader())
                        {
                            while (res1.Read())
                            {
                                Project project = new Project
                                {
                                    ProjectId = res1.GetInt32("id"),
                                    ProjectName = res1.GetString("projectName"),
                                    ProjectDescription = res1.GetString("projectDescription"),
                                    ProjectSkills = res1.GetString("projectSkills"),
                                    ProjectBudget = res1.GetDouble("projectBudget"),
                                    ProjectDuration = res1.GetString("projectDuration"),
                                    ProjectStatus = res1.GetString("projectStatus"),
                                    ProjectDeadline = res1.GetString("projectDeadline"),
                                    ProjectCompletedDate = res1.GetDateTime("projectCompletedDate"),
                                    ProjectCreatedDate = res1.GetDateTime("projectCreatedDate")
                                };
                                projects.Add(project);
                            }
                        }
                    }
                    connection.Close();

                    string statue = "Waiting";
                    projects.RemoveAll(x => x.ProjectStatus == statue);
                    return projects;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public Client GetClientByProjectId(int pid)
        {
            Client client = new Client();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT client_id FROM adi_assignment.client_project WHERE project_id = @pid";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        using (MySqlDataReader res = cmd.ExecuteReader())
                        {
                            if (res.Read())
                            {
                                int cid = res.GetInt32("client_id");
                                res.Close();

                                string query1 = "SELECT * FROM client WHERE id = @cid";
                                using (MySqlCommand cmd1 = new MySqlCommand(query1, connection))
                                {
                                    cmd1.Parameters.AddWithValue("@cid", cid);
                                    using (MySqlDataReader res1 = cmd1.ExecuteReader())
                                    {
                                        if (res1.Read())
                                        {
                                            client.ClientId = res1.GetInt32("id");
                                            client.CompanyName = res1.GetString("companyName");
                                            client.CompanyAddress = res1.GetString("companyAddress");
                                            client.CompanyPhone = res1.GetString("companyPhone");
                                            client.CompanyEmail = res1.GetString("companyEmail");
                                            client.CompanyWebsite = res1.GetString("companyWebsite");
                                            client.CompanyDescription = res1.GetString("companyDescription");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
            return client;
        }

        public bool ApplyProject(int pid, int fid)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM freelancer_project WHERE project_id = @pid AND freelancer_id = @fid";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        cmd.Parameters.AddWithValue("@fid", fid);
                        using (MySqlDataReader res = cmd.ExecuteReader())
                        {
                            if (res.Read())
                            {
                                MessageBox.Show("Already Applied");
                                return false;
                            }
                        }
                    }
                    connection.Close();

                    connection.Open();
                    string insertQuery = "INSERT INTO freelancer_project (project_id, freelancer_id,applied_date) VALUES (@pid, @fid,@date)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        cmd.Parameters.AddWithValue("@fid", fid);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    connection.Open();
                    string updateQuery = "UPDATE project SET projectStatus = 'Waiting' WHERE id = @pid";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool AcceptedProject(int pid , int cid)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE project SET projectStatus = 'Accepted' WHERE id = @pid";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    connection.Open();
                    string query1 = "SELECT * FROM adi_assignment.client_project WHERE project_id = @pid AND client_id = @cid";
                    using (MySqlCommand cmd1 = new MySqlCommand(query1, connection))
                    {
                        cmd1.Parameters.AddWithValue("@pid", pid);
                        cmd1.Parameters.AddWithValue("@cid", cid);
                        using (MySqlDataReader res = cmd1.ExecuteReader())
                        {
                            if (res.Read())
                            {
                                return true;
                            }
                        }
                    }
                    connection.Close();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool CompleteProject(int pid)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE project SET projectStatus = 'Completed', projectCompletedDate = @date WHERE id = @pid";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public Freelancer GetFreelancerWithBidProject(int pid)
        {
            Freelancer freelancer = new Freelancer();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT freelancer_id FROM freelancer_project WHERE project_id = @pid";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        using (MySqlDataReader res = cmd.ExecuteReader())
                        {
                            if (res.Read())
                            {
                                int fid = res.GetInt32("freelancer_id");
                                res.Close();
                                string query1 = "SELECT * FROM freelancer WHERE id = @fid";
                                using (MySqlCommand cmd1 = new MySqlCommand(query1, connection))
                                {
                                    cmd1.Parameters.AddWithValue("@fid", fid);
                                    using (MySqlDataReader res1 = cmd1.ExecuteReader())
                                    {
                                        if (res1.Read())
                                        {
                                            freelancer.FreelancerId = res1.GetInt32("id");
                                            freelancer.Skills = res1.GetString("skills");
                                            freelancer.Expertise = res1.GetString("expertise");
                                            freelancer.Porfolio = res1.GetString("porfolio");
                                            freelancer.Id = res1.GetInt32("userid");
                                        }
                                    }
                                }
                            }

                            string query2 = "SELECT * FROM user WHERE id = @id";
                            using (MySqlCommand cmd2 = new MySqlCommand(query2, connection))
                            {
                                cmd2.Parameters.AddWithValue("@id", freelancer.Id);
                                using (MySqlDataReader res2 = cmd2.ExecuteReader())
                                {
                                    if (res2.Read())
                                    {
                                        freelancer.Username = res2.GetString("username");
                                        freelancer.Email = res2.GetString("email");
                                        freelancer.Phone = res2.GetString("phone");
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
            return freelancer;
        }

        public List<Project> ProjectsByStatus(string statue, int cid)
        {
            List<Project> projects = new List<Project>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT project_id FROM adi_assignment.client_project WHERE client_id = @cid";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cid", cid);
                        using (MySqlDataReader res = cmd.ExecuteReader())
                        {
                            List<int> projectIds = new List<int>();
                            while (res.Read())
                            {
                                projectIds.Add(res.GetInt32("project_id"));
                            }
                            res.Close();
                            foreach (int pid in projectIds)
                            {
                                string query1 = "SELECT * FROM project WHERE id = @pid AND projectStatus = @statue";
                                using (MySqlCommand cmd1 = new MySqlCommand(query1, connection))
                                {
                                    cmd1.Parameters.AddWithValue("@pid", pid);
                                    cmd1.Parameters.AddWithValue("@statue", statue);
                                    using (MySqlDataReader res1 = cmd1.ExecuteReader())
                                    {
                                        if (res1.Read())
                                        {
                                            Project project = new Project
                                            {
                                                ProjectId = res1.GetInt32("id"),
                                                ProjectName = res1.GetString("projectName"),
                                                ProjectDescription = res1.GetString("projectDescription"),
                                                ProjectSkills = res1.GetString("projectSkills"),
                                                ProjectBudget = res1.GetDouble("projectBudget"),
                                                ProjectDuration = res1.GetString("projectDuration"),
                                                ProjectStatus = res1.GetString("projectStatus"),
                                                ProjectDeadline = res1.GetString("projectDeadline"),
                                                ProjectCompletedDate = res1.GetDateTime("projectCompletedDate"),
                                                ProjectCreatedDate = res1.GetDateTime("projectCreatedDate")
                                            };
                                            projects.Add(project);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    return projects;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }

        }

        public bool RateProject(int pid,int cid, int fid, float rating)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "insert into rating (rating, project_id, client_id, freelancer_id) values (@rating, @project_id, @client_id, @freelancer_id)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@rating", rating);
                        cmd.Parameters.AddWithValue("@project_id", pid);
                        cmd.Parameters.AddWithValue("@client_id", cid);
                        cmd.Parameters.AddWithValue("@freelancer_id", fid);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in dao: " + ex.Message);
                    return false;
                }
            }
        }

        public Rating GetRatingListByProjectId(int pid)
        {
            connection = new MySqlConnection(connectionString);
            Rating rating = new Rating();
            try
            {
                connection.Open();
                string query = "SELECT * FROM rating WHERE project_id = @pid";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@pid", pid);
                MySqlDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    rating.RatingId = res.GetInt32("id");
                    rating.RatingValue = res.GetFloat("rating");
                    rating.ProjectId = res.GetInt32("project_id");
                    rating.ClientId = res.GetInt32("client_id");
                    rating.FreelancerId = res.GetInt32("freelancer_id");
                    
                }
                connection.Close();
                return rating;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }
    }
}
