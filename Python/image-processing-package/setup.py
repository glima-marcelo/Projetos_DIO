from setuptools import setup, find_packages

with open("README.md", "r") as f:
    page_description = f.read()

with open("requirements.txt") as f:
    requirements = f.read().splitlines()

setup(
    name="image-processing",
    version="0.0.1",
    author="Marcelo Goulart Lima",
    author_email="glima.marcelo@gmail.com",
    description="Projeto DIO - processamento de imagens com Python",
    long_description=page_description,
    long_description_content_type="text/markdown",
    url="my_github_repository_project_link",
    packages=find_packages(),
    install_requires=requirements,
    python_requires='>=3.5',
)
