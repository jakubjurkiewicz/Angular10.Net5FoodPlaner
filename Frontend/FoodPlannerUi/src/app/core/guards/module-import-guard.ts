export function throwIfAlreadyLoaded(parentModule: any, moduleName: string){
    if(parentModule){
        throw new Error(`${moduleName} has already been loaded. Import Core modules only in the app module`);
    }
}