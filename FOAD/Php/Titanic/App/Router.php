<?php

namespace Titanic;

/**
 * Class Router
 * @package Titanic
 */
class Router
{
    private string $request;

    private array $route;

    private string $controller;

    public function __construct(string $baseUrl = "/")
    {
        $this->request = $_SERVER['REQUEST_URI'];

        if ($baseUrl !== "/") {
            $this->request = str_replace($baseUrl, '', $this->request);
        }

        $this->request = ltrim($this->request, "/");

        $this->route = explode('/', $this->request);

        $this->controller = !empty($this->route[0]) ? $this->route[0] : 'home';

        $this->controller = mb_convert_case($this->controller, MB_CASE_TITLE);

        $this->controller = "Titanic\\Controllers\\".$this->controller."Controller";

    }

    public function getController() : string
    {
        return $this->controller;
    }

    public function getAction() : string
    {
        return !empty($this->route[1]) ? $this->route[1] : 'index';
    }

    public function getId() : ?string
    {
        return !empty($this->route[2]) ? $this->route[2] : null;
    }
}